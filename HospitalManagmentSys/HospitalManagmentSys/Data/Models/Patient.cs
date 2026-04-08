using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum MedicalUrgency
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public class Patient
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NoShowCount { get; set; }
        public double AttendanceRate { get; set; }  
        public Gender Gender { get; set; }
        public MedicalUrgency MedicalUrgency { get; set; }
        public DateTime CreatedAt { get; set; } 
        public List<Appointment>? Appointments { get; set; } = new();
    }
}
