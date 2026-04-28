using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentSys.BiussnessLogic
{
    public class QueueService
    {
        private readonly AppDbContext _context;

        public QueueService(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets all active doctors for Admin/Receptionist to select from.
        /// </summary>
        public List<Doctor> GetActiveDoctors()
        {
            return _context.Doctors
                .Include(d => d.User)
                .Include(d => d.Department)
                .Where(d => d.User.IsActive)
                .ToList();
        }

        /// <summary>
        /// Gets the current time slot for a doctor (today's active slot).
        /// </summary>
        public TimeSlot? GetCurrentTimeSlotForDoctor(int doctorId)
        {
            var today = DateTime.Today;
            return _context.TimeSlots
                .Include(ts => ts.Appointments)
                .Where(ts => ts.DoctorId == doctorId
                             && ts.SlotDate == today
                             && ts.IsAvailable)
                .FirstOrDefault();
        }

        /// <summary>
        /// Gets all time slots for a specific doctor for today.
        /// </summary>
        public List<TimeSlot> GetTodayTimeSlotsForDoctor(int doctorId)
        {
            var today = DateTime.Today;
            return _context.TimeSlots
                .Include(ts => ts.Appointments)
                .Where(ts => ts.DoctorId == doctorId && ts.SlotDate == today)
                .OrderBy(ts => ts.StartTime)
                .ToList();
        }

        /// <summary>
        /// Gets the queue for a specific doctor's current time slot.
        /// </summary>
        public IReadOnlyList<Appointment> GetDoctorQueue(int doctorId)
        {
            var timeSlot = GetCurrentTimeSlotForDoctor(doctorId);
            if (timeSlot == null)
                return new List<Appointment>();

            return GetQueue(timeSlot.Id);
        }

        /// <summary>
        /// Gets the queue for a specific doctor's time slot.
        /// </summary>
        public IReadOnlyList<Appointment> GetDoctorQueueByTimeSlot(int doctorId, int timeSlotId)
        {
            return _context.Appointments

                .Where(a => a.DoctorId == doctorId
                         && a.TimeSlotId == timeSlotId
                         && a.Status != AppointmentStatus.Cancelled
                         && a.Status != AppointmentStatus.Completed)
                .Include(a => a.Doctor).ThenInclude(d => d.User)
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .OrderByDescending(a => a.PriorityScore)
                .ThenBy(a => a.QueueOrder)
                .ToList();
        }

        /// <summary>
        /// Gets the current patient (first in queue) for a doctor.
        /// </summary>
        public Appointment? GetCurrentPatient(int doctorId)
        {
            var queue = GetDoctorQueue(doctorId);
            return queue.FirstOrDefault();
        }

        /// <summary>
        /// Gets waiting patients (excluding current patient) for a doctor.
        /// </summary>
        public IReadOnlyList<Appointment> GetWaitingPatients(int doctorId)
        {
            var queue = GetDoctorQueue(doctorId);
            return queue.Skip(1).ToList();
        }

        /// <summary>
        /// Adds a patient to a doctor's queue.
        /// </summary>
        public bool AddPatientToQueue(int patientId, int doctorId, int timeSlotId, string? description = null)
        {
            var patient = _context.Patients.Find(patientId);
            if (patient == null) return false;

            var timeSlot = _context.TimeSlots.Find(timeSlotId);
            if (timeSlot == null || !timeSlot.IsAvailable) return false;

            var appointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = doctorId,
                TimeSlotId = timeSlotId,
                Description = description,
                Status = AppointmentStatus.Pending,
                PriorityScore = CalculatePriorityScore(patient),
                QueueOrder = timeSlot.BookedCount + 1,
                AppointmentDate = timeSlot.SlotDate.Date + timeSlot.StartTime + TimeSpan.FromMinutes((timeSlot.BookedCount) * 30)
            };

            _context.Appointments.Add(appointment);
            timeSlot.BookedCount++;
            timeSlot.IsAvailable = timeSlot.BookedCount < timeSlot.MaxCapacity;

            ReorderQueue(timeSlotId);
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Marks an appointment as completed and advances the queue.
        /// </summary>
        public bool CompleteAppointment(int appointmentId)
        {
            var appointment = _context.Appointments
                .Include(a => a.TimeSlot)
                .FirstOrDefault(a => a.Id == appointmentId);

            if (appointment == null) return false;

            appointment.Status = AppointmentStatus.Completed;
            ReorderQueue(appointment.TimeSlotId);
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Marks a patient as being seen (starts consultation) for the current appointment.
        /// </summary>
        public bool StartPatientConsultation(int appointmentId)
        {
            var appointment = _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .FirstOrDefault(a => a.Id == appointmentId);

            if (appointment == null) return false;

            // Update appointment status to indicate patient is being seen
            appointment.Status = AppointmentStatus.Confirmed;
            
            // Update patient attendance rate (increment successful visits)
            var patient = appointment.Patient;
            var totalAppointments = patient.Appointments?.Count(a => a.Status == AppointmentStatus.Completed) ?? 0;
            patient.AttendanceRate = Math.Min(1.0, (totalAppointments + 1) / (double)(totalAppointments + 1 + patient.NoShowCount));

            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Marks a patient as no-show, cancels the appointment, and updates patient record.
        /// </summary>
        public bool MarkPatientAsNoShow(int appointmentId)
        {
            var appointment = _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .FirstOrDefault(a => a.Id == appointmentId);

            if (appointment == null) return false;

            // Cancel the appointment
            appointment.Status = AppointmentStatus.Cancelled;
            
            // Update patient no-show count and attendance rate
            var patient = appointment.Patient;
            patient.NoShowCount++;
            
            var totalAppointments = patient.Appointments?.Count(a => a.Status == AppointmentStatus.Completed) ?? 0;
            patient.AttendanceRate = Math.Max(0.0, totalAppointments / (double)(totalAppointments + patient.NoShowCount));

            // Recalculate priority score based on new attendance/no-show stats
            appointment.PriorityScore = CalculatePriorityScore(patient);

            // Reorder the queue to reflect updated priorities
            ReorderQueue(appointment.TimeSlotId);
            
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Computes a priority score for a patient.
        /// Higher score = seen sooner.
        ///   Urgency       : Emergency=8, High=6, Medium=4, Low=2  (always dominates)
        ///   AttendanceRate: 0-1 pts
        ///   NoShowPenalty : up to -1 pt
        /// </summary>
        public static double CalculatePriorityScore(Patient patient)
        {
            double urgency = patient.MedicalUrgency switch
            {
                MedicalUrgency.Emergency => 8.0,
                MedicalUrgency.High => 6.0,
                MedicalUrgency.Medium => 4.0,
                MedicalUrgency.Low => 2.0,
                _ => 2.0
            };

            double attendance = Math.Clamp(patient.AttendanceRate, 0.0, 1.0);
            double noShowPenalty = Math.Min(patient.NoShowCount * 0.25, 1.0);

            return urgency + attendance - noShowPenalty;
        }

        /// <summary>
        /// Returns the active (non-cancelled, non-completed) queue for a time slot,
        /// ordered by priority descending, then by original QueueOrder as a tie-breaker.
        /// </summary>
        public IReadOnlyList<Appointment> GetQueue(int timeSlotId)
        {
            return _context.Appointments
                .Where(a => a.TimeSlotId == timeSlotId
                         && a.Status != AppointmentStatus.Cancelled
                         && a.Status != AppointmentStatus.Completed)
                .Include(a => a.Patient)
                .Include(a => a.Doctor).ThenInclude(d => d.User)
                .OrderByDescending(a => a.PriorityScore)
                .ThenBy(a => a.QueueOrder)
                .ToList();
        }

        /// <summary>
        /// Returns the next patient to be seen in the slot.
        /// </summary>
        public Appointment? GetNextPatient(int timeSlotId)
        {
            return GetQueue(timeSlotId).FirstOrDefault();
        }

        /// <summary>
        /// Recomputes QueueOrder and AppointmentDate for every active appointment
        /// in the slot based on current priority scores (highest priority = position 1).
        /// Each position is a 30-minute window starting from SlotDate + StartTime.
        /// Call this after any booking or cancellation.
        /// </summary>
        public void ReorderQueue(int timeSlotId)
        {
            var timeSlot = _context.TimeSlots
                .Include(ts => ts.Appointments)
                    .ThenInclude(a => a.Patient)
                .FirstOrDefault(ts => ts.Id == timeSlotId);

            if (timeSlot == null) return;

            var active = timeSlot.Appointments
                .Where(a => a.Status != AppointmentStatus.Cancelled
                         && a.Status != AppointmentStatus.Completed)
                .OrderByDescending(a => a.PriorityScore)
                .ThenBy(a => a.QueueOrder)
                .ToList();

            DateTime windowStart = timeSlot.SlotDate.Date + timeSlot.StartTime;

            for (int i = 0; i < active.Count; i++)
            {
                active[i].QueueOrder = i + 1;
                active[i].AppointmentDate = windowStart.AddMinutes(i * 30);
            }

            timeSlot.BookedCount = active.Count;
            timeSlot.IsAvailable = active.Count < timeSlot.MaxCapacity;

            _context.SaveChanges();
        }

        /// <summary>
        /// Adds an emergency patient to the front of the doctor's queue.
        /// </summary>
        public bool AddEmergencyPatient(int patientId, int doctorId, string? description = null)
        {
            var patient = _context.Patients.Find(patientId);
            if (patient == null) return false;

            var doctor = _context.Doctors.Find(doctorId);
            if (doctor == null) return false;

            var today = DateTime.Today;
            var timeSlot = _context.TimeSlots
                .FirstOrDefault(ts => ts.DoctorId == doctorId
                                     && ts.SlotDate == today
                                     && ts.IsAvailable);

            if (timeSlot == null)
            {
                timeSlot = new TimeSlot
                {
                    DoctorId = doctorId,
                    SlotDate = today,
                    StartTime = TimeSpan.FromHours(8),
                    EndTime = TimeSpan.FromHours(17),
                    MaxCapacity = 50,
                    BookedCount = 0,
                    IsAvailable = true
                };
                _context.TimeSlots.Add(timeSlot);
            }

            var originalUrgency = patient.MedicalUrgency;
            patient.MedicalUrgency = MedicalUrgency.Emergency;

            var appointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = doctorId,
                TimeSlotId = timeSlot.Id,
                Description = description ?? "Emergency admission",
                Status = AppointmentStatus.Pending,
                PriorityScore = CalculatePriorityScore(patient),
                QueueOrder = 1,
                AppointmentDate = DateTime.Now
            };

            patient.MedicalUrgency = originalUrgency;

            _context.Appointments.Add(appointment);
            timeSlot.BookedCount++;
            timeSlot.IsAvailable = timeSlot.BookedCount < timeSlot.MaxCapacity;

            ReorderQueue(timeSlot.Id);

            var allAppointments = _context.Appointments
                .Where(a => a.TimeSlotId == timeSlot.Id && a.Status != AppointmentStatus.Cancelled)
                .OrderBy(a => a.AppointmentDate)
                .ToList();

            for (int i = 0; i < allAppointments.Count; i++)
            {
                if (allAppointments[i].Id == appointment.Id)
                {
                    allAppointments[i].QueueOrder = 1;
                    allAppointments[i].AppointmentDate = DateTime.Now;
                }
                else if (allAppointments[i].QueueOrder == 1)
                {
                    allAppointments[i].QueueOrder = i + 2;
                }
            }

            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Gets all patients for emergency selection.
        /// </summary>
        public List<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }
    }
}