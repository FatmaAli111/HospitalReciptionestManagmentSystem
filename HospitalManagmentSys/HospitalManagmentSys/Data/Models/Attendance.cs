using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public enum AttendanceStatus
    {
        Present=1,
        Absent=2,
        Late=3,
        Cancelled=4
    }
    public class Attendance
    {
        public int Id { get; set; }
        public int AppointmentID { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public DateTime ArriveTime { get; set; }
        public AttendanceStatus Status { get; set; }
        public Appointment Appointment { get; set; }

    }
}
