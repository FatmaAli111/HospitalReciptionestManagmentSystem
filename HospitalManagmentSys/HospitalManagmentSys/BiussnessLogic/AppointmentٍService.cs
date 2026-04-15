using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using HospitalManagmentSys.BiussnessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
    public class AppointmentService
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

            bool samePatientSameDay = _context.Appointments
                .Any(a => a.PatientId == appointment.PatientId
                       && a.AppointmentDate.Date == dateTime.Date
                       && a.Status != AppointmentStatus.Cancelled);
            if (samePatientSameDay)
                return "This patient already has an appointment on this day.";

            TimeSlot? timeSlot = _context.TimeSlots
                .Include(t => t.Appointments)
               .FirstOrDefault(t => t.DoctorId == appointment.DoctorId
                      && t.SlotDate.Date == dateTime.Date);
            if (timeSlot == null)
                return "No available time slots for this doctor on the selected date.";

            TimeSpan nextTime = timeSlot.StartTime;
            while (nextTime < timeSlot.EndTime)
            {
                bool isTaken = timeSlot.Appointments
                    .Any(a => a.AppointmentDate == timeSlot.SlotDate.Date + nextTime
                           && a.Status != AppointmentStatus.Cancelled);
                if (!isTaken) break;
                nextTime = nextTime.Add(TimeSpan.FromMinutes(30));
            }

            if (nextTime >= timeSlot.EndTime)
                return "No available time slots for this doctor on the selected date.";

            appointment.TimeSlotId = timeSlot.Id;
            appointment.Status = AppointmentStatus.Pending;
            appointment.QueueOrder = timeSlot.Appointments
                .Count(a => a.Status != AppointmentStatus.Cancelled) + 1;
            appointment.AppointmentDate = timeSlot.SlotDate.Date + nextTime;

            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            var queueService = new QueueService(_context);
            queueService.ReorderQueue(appointment.TimeSlotId);
            return "Appointment booked successfully!";
        }
        public IEnumerable<Appointment> GetAppointmentsByDate(DateTime date)
        {
            return _context.Appointments
                .Where(a => a.AppointmentDate.Date == date.Date)
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .ThenInclude(d => d.User);
        }
        //public void UpdateStatus(AppointmentStatus Status, int Id)
        //{
        //    Appointment? appointment = _context.Appointments
        //        .Include(a => a.TimeSlot)
        //            .ThenInclude(ts => ts.Appointments)
        //        .FirstOrDefault(i => i.Id == Id);

        //    if (appointment == null) return;

        //    appointment.Status = Status;

        //    if (Status == AppointmentStatus.Cancelled)
        //    {
        //        var timeSlot = appointment.TimeSlot;
        //        bool isBefore = appointment.AppointmentDate > DateTime.Now;

        //        if (isBefore)
        //        {
        //            var laterAppointments = timeSlot.Appointments
        //                .Where(a => a.QueueOrder > appointment.QueueOrder
        //                         && a.Status != AppointmentStatus.Cancelled)
        //                .OrderBy(a => a.QueueOrder)
        //                .ToList();

        //            foreach (var apt in laterAppointments)
        //            {
        //                apt.QueueOrder--;
        //                apt.AppointmentDate = apt.AppointmentDate.AddMinutes(-30);
        //            }

        //            timeSlot.BookedCount--;
        //            timeSlot.IsAvailable = true;
        //        }
        //        else
        //        {
        //            if(timeSlot.BookedCount > 0)
        //            timeSlot.BookedCount--;
        //            timeSlot.IsAvailable = true;
        //        }
        //    }

        //    _context.SaveChanges();
        //}

        public void UpdateStatus(AppointmentStatus status, int id)
        {
            Appointment? appointment = _context.Appointments.Find(id);
            if (appointment == null) return;
            appointment.Status = status;
            _context.SaveChanges();
            var queueService = new QueueService(_context);
            queueService.ReorderQueue(appointment.TimeSlotId);
        }
    }
}
