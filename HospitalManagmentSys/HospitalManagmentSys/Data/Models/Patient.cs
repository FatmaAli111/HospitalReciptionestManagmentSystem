using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagmentSys.Data.Models;

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
        High = 3,
        Emergency=4
    }

    public enum BloodType
    {
        A_Positive = 1,
        A_Negative = 2,
        B_Positive = 3,
        B_Negative = 4,
        AB_Positive = 5,
        AB_Negative = 6,
        O_Positive = 7,
        O_Negative = 8
    }

    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public BloodType BloodType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NoShowCount { get; set; }
        public double AttendanceRate { get; set; }
        public Gender Gender { get; set; }
        public MedicalUrgency MedicalUrgency { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Appointment>? Appointments { get; set; } = new();

        public int Age =>
            (int)((DateTime.Now - DateOfBirth).TotalDays / 365.25);

        public int TotalAppointments =>
            Appointments?.Count ?? 0;

        public string Initials
        {
            get
            {
                var parts = FullName.Split(' ');
                if (parts.Length >= 2)
                    return $"{parts[0][0]}{parts[1][0]}";
                return FullName.Substring(0, 2).ToUpper();
            }
        }
    }
}