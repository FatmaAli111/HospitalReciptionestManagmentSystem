using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
        public class SignupService
        {
            private readonly AppDbContext _context;

            public SignupService()
            {
                _context = new AppDbContext();
            }

            public bool EmailExists(string email)
            {
                return _context.Users.Any(u => u.Email == email);
            }

            public void AddUser(User user)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }


        }

}
