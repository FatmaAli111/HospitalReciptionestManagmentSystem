using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{

    public class UserRequest
    {
        public int ID { get; set; }
        public UserRole Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Speciality { get; set; }
        public string PasswordHash { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime RequestDate { get; set; } = DateTime.Now;

        public bool IsAccountCreated { get; set; } = false;
        public int? UserID { get; set; }     
        public User? User { get; set; }    
    }
};