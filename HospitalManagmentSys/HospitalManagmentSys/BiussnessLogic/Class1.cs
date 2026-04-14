using System;
using System.Collections.Generic;
using System.Linq;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.BiussnessLogic
{
    public static class AppointmentService
    {
        // Small helper methods moved to business logic so UI can call them.
        public static (int pending, int confirmed, int completed, int cancelled) GetAppointmentStatusCounts(AppDbContext ctx)
        {
            var appts = ctx.Appointments.ToList();
            int pending = appts.Count(a => a.Status == AppointmentStatus.Pending);
            int confirmed = appts.Count(a => a.Status == AppointmentStatus.Confirmed);
            int completed = appts.Count(a => a.Status == AppointmentStatus.Completed);
            int cancelled = appts.Count(a => a.Status == AppointmentStatus.Cancelled);
            return (pending, confirmed, completed, cancelled);
        }

        public static Dictionary<string,int> GetAppointmentCountsByStatus(AppDbContext ctx)
        {
            return ctx.Appointments
                .AsEnumerable()
                .GroupBy(a => a.Status.ToString())
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
