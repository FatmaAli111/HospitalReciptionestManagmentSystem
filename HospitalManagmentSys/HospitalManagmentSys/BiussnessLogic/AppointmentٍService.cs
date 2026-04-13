using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
    class AppointmentService
    {
        private readonly AppDbContext _context;
        public AppointmentService()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.Include(d=>d.User);
        }
        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients;
        }

        public string AddAppointment(Appointment appointment, DateTime dateTime)
        {
            bool sameDoctorSameDay = _context.Appointments
                .Any(a => a.PatientId == appointment.PatientId
                       && a.DoctorId == appointment.DoctorId
                       && a.AppointmentDate.Date == dateTime.Date
                       && a.Status != AppointmentStatus.Cancelled);

            if (sameDoctorSameDay)
                return "This patient already has an appointment with this doctor on the same day.";

            bool sameTimeDifferentDoctor = _context.Appointments
                .Any(a => a.PatientId == appointment.PatientId
                       && a.AppointmentDate == dateTime
                       && a.Status != AppointmentStatus.Cancelled);

            if (sameTimeDifferentDoctor)
                return "This patient already has an appointment at this time.";

            TimeSlot? timeSlot = _context.TimeSlots
                .FirstOrDefault(t => t.DoctorId == appointment.DoctorId
                                  && t.SlotDate.Date == dateTime.Date
                                  && t.StartTime <= dateTime.TimeOfDay
                                  && t.EndTime >= dateTime.TimeOfDay
                                  && t.IsAvailable == true
                                  && t.BookedCount < t.MaxCapacity);

            if (timeSlot == null)
                return "No available time slots for this doctor on the selected date and time.";
            TimeSpan appointmentTime = timeSlot.StartTime
            .Add(TimeSpan.FromMinutes(30 * timeSlot.BookedCount));

            bool sameTimeAlreadyBooked = _context.Appointments
                .Any(a => a.TimeSlotId == timeSlot.Id
                       && a.AppointmentDate == timeSlot.SlotDate.Date + appointmentTime
                       && a.Status != AppointmentStatus.Cancelled);

            if (sameTimeAlreadyBooked)
                return "This time is already booked, please choose another time.";

            appointment.TimeSlotId = timeSlot.Id;
            appointment.Status = AppointmentStatus.Pending;
            appointment.QueueOrder = timeSlot.BookedCount + 1;
            appointment.AppointmentDate = timeSlot.SlotDate.Date + appointmentTime;

            timeSlot.BookedCount++;
            if (timeSlot.BookedCount >= timeSlot.MaxCapacity)
                timeSlot.IsAvailable = false;

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return "Appointment booked successfully!";
        }
        public IEnumerable<Appointment> GetAppointmentsByDate(DateTime date)
        {
            return _context.Appointments
                .Where(a => a.AppointmentDate.Date == date.Date)
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .ThenInclude(d => d.User)
                .AsNoTracking();
        }

    }
}
