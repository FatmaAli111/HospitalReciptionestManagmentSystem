using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
    internal class DashbordServices
    {
        private readonly AppDbContext _appDbContext;
        public DashbordServices()
        {
            _appDbContext = new AppDbContext();
        }
        public int totalPatients ()
        {
           return _appDbContext.Appointments.Where(a=>a.TimeSlot.SlotDate.Date== DateTime.Today).Select(a => a.Patient).Distinct().Count();

        }
        public int todayAppointments()
        {
            return _appDbContext.Appointments.Where(a => a.TimeSlot.SlotDate.Date == DateTime.Today).Count();

        }
        public int NoShowNumber()
        {
            return _appDbContext.Appointments.Where(a => a.Attendance.Status == AttendanceStatus.Absent && a.Status == AppointmentStatus.Cancelled && a.TimeSlot.SlotDate.Date == DateTime.Today).Count();
        }
        public int TodayAppointmentsCompleted()
        {
            return _appDbContext.Appointments
                .AsNoTracking()
                .Select(a => a.TimeSlot.SlotDate.Date == DateTime.Today
                         && a.Status == AppointmentStatus.Completed)
                .Count();
        }

        public int WaitingNow()
        {
            var now = DateTime.Now;

            return _appDbContext.Appointments
                .Where(a =>
                    a.TimeSlot.SlotDate.Date == DateTime.Today &&
                    a.TimeSlot.StartTime <= now.TimeOfDay &&
                    a.Attendance.Status == AttendanceStatus.Present).Count();
        }
        public List<User> DoctorsAvailable()
        {
         
           return _appDbContext.Users
        .AsNoTracking()
        .Where(u => u.IsActive && u.Role == UserRole.Doctor)
        .Include(u => u.Doctor)
        .ToList();
        }
        public string FChar(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "??";

            var parts = name.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
                if (parts.Length >= 2)
                {
                return parts[1][0].ToString().ToUpper();
            }



            return name[0].ToString().ToUpper();
        }
        public string FCharr(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "??";

            var parts = name.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


         



            return name[0].ToString().ToUpper();
        }
        public List<Appointment> Appoinments()
        {

          return _appDbContext.Appointments
         .AsNoTracking()
         //.Where(u => u.TimeSlot.SlotDate.Date == DateTime.Today && u.TimeSlot.StartTime>= DateTime.Now.TimeOfDay)
         .Include(u => u.TimeSlot)
         .Include(u => u.Doctor )
         .Include(u=>u.Patient)
         .ToList();
        }





    }
}
