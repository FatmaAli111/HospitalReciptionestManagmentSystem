using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.BiussnessLogic
{
    /// <summary>
    /// Controller for queue management operations.
    /// Provides a clean interface for UI components (like the sidebar) to interact with queue functionality.
    /// </summary>
    public class QueueController
    {
        private readonly QueueService _queueService;

        public QueueController(AppDbContext context)
        {
            _queueService = new QueueService(context);
        }

        /// <summary>
        /// Gets all active doctors for display in the UI.
        /// </summary>
        public List<Doctor> GetActiveDoctors()
        {
            return _queueService.GetActiveDoctors();
        }

        /// <summary>
        /// Gets the queue for a specific doctor.
        /// </summary>
        public IReadOnlyList<Appointment> GetDoctorQueue(int doctorId)
        {
            return _queueService.GetDoctorQueue(doctorId);
        }

        /// <summary>
        /// Gets the current patient (first in queue) for a doctor.
        /// </summary>
        public Appointment? GetCurrentPatient(int doctorId)
        {
            return _queueService.GetCurrentPatient(doctorId);
        }

        /// <summary>
        /// Gets waiting patients for a doctor.
        /// </summary>
        public IReadOnlyList<Appointment> GetWaitingPatients(int doctorId)
        {
            return _queueService.GetWaitingPatients(doctorId);
        }

        /// <summary>
        /// Starts consultation for a patient.
        /// </summary>
        public bool StartPatientConsultation(int appointmentId)
        {
            return _queueService.StartPatientConsultation(appointmentId);
        }

        /// <summary>
        /// Marks a patient as no-show.
        /// </summary>
        public bool MarkPatientAsNoShow(int appointmentId)
        {
            return _queueService.MarkPatientAsNoShow(appointmentId);
        }

        /// <summary>
        /// Adds an emergency patient to the front of the doctor's queue.
        /// </summary>
        public bool AddEmergencyPatient(int patientId, int doctorId, string? description = null)
        {
            return _queueService.AddEmergencyPatient(patientId, doctorId, description);
        }

        /// <summary>
        /// Gets all patients for selection.
        /// </summary>
        public List<Patient> GetAllPatients()
        {
            return _queueService.GetAllPatients();
        }

        /// <summary>
        /// Reorders the queue by priority for a doctor's current time slot.
        /// </summary>
        public bool ReorderQueue(int doctorId)
        {
            var timeSlot = _queueService.GetCurrentTimeSlotForDoctor(doctorId);
            if (timeSlot == null) return false;
            
            _queueService.ReorderQueue(timeSlot.Id);
            return true;
        }

        /// <summary>
        /// Gets queue statistics for a doctor.
        /// </summary>
        public QueueStatistics GetQueueStatistics(int doctorId)
        {
            var queue = _queueService.GetDoctorQueue(doctorId);
            var emergencies = queue.Count(a => a.Patient.MedicalUrgency == MedicalUrgency.Emergency);
            
            return new QueueStatistics
            {
                TotalPatients = queue.Count,
                EmergencyCount = emergencies,
                WaitingCount = queue.Count > 0 ? queue.Count - 1 : 0
            };
        }
    }

    /// <summary>
    /// Statistics about the current queue.
    /// </summary>
    public class QueueStatistics
    {
        public int TotalPatients { get; set; }
        public int EmergencyCount { get; set; }
        public int WaitingCount { get; set; }
    }
}
