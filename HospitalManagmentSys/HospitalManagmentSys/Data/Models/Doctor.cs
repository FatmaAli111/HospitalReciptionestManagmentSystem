
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Specialty { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Department Department { get; set; }
        public List<TimeSlot> TimeSlots { get; set; } = new();
        public List<Appointment> Appointments { get; set; } = new();
        public Doctor()
        {
            
        }
        public Doctor(User user, string spec)
        {
            this.User = user;
            this.UserId = user.Id;
            this.Specialty = spec;
        }


    }
}
