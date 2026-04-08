using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public DateTime SlotDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int MaxCapacity { get; set; }
        public int BookedCount { get; set; }
        public bool IsAvailable { get; set; }
        public Doctor Doctor { get; set; }
        public List<Appointment> Appointments { get; set; } = new();
    }
}
