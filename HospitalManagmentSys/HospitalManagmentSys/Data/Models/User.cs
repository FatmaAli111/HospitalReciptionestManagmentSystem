using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public enum UserRole
    {
        Admin = 1,
        Doctor = 2,
        Receptionist = 3
    }
    public class User
    {
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool Isactive { get; set; }
        public DateTime CreatedAt { get; set; }
        public Doctor Doctor { get; set; }
    }
}
