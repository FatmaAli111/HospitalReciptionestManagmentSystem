using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public enum AppointmentStatus
    {
        Pending=1,      
        Confirmed=2,    
        Completed=3,   
        Cancelled=4     
    }
    public class Appointment
    {
        public int Id { get; set; }
        public AppointmentStatus Status { get; set; }
        public int WaitingTimeScore {  get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public Attendence Attendence { get; set; }
        public Queue Queue { get; set; }

    }
}
