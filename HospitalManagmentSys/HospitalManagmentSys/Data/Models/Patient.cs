using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    [Flags]
    public enum NoShowStatus
    {
        None = 0,
        Good = 1,
        Warning = 2,
        HighRisk = 4
    }

    public class Patient
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }
        public int Age { get; set; }
        public int TotalAppointments { get; set; }
        public int NoShowCount { get; set; }

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

        public NoShowStatus NoShowStatus
        {
            get
            {
                if (NoShowCount == 0) return NoShowStatus.Good;
                if (NoShowCount >= 4) return NoShowStatus.HighRisk;
                return NoShowStatus.Warning;
            }
        }
    }
}
