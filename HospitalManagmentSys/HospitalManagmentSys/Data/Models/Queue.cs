using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public enum QueueStatus
    {
        Waiting = 1,
        InProgress = 2,
        Completed = 3,
        Cancelled = 4
    }
    public class Queue
    {
        public int Id { get; set; }
        public double PriorityScore { get; set; }
        public int QueueOrder { get; set; }
        public DateTime LastUpdated {  get; set; }
        public QueueStatus Status { get; set; }
        public Appointment Appointment { get; set; }
    }
}
