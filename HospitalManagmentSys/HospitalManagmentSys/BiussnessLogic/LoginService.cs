using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
   
    
        public class LoginService
        {
            private readonly AppDbContext _context;

            public LoginService()
            {
                _context = new AppDbContext();
            }

            public User GetUserByEmail(string email)
            {
                return _context.Users.FirstOrDefault(u => u.Email == email);
            }
        }
}
