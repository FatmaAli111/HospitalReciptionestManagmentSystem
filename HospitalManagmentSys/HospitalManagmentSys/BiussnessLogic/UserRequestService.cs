using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
        public class UserRequestService
        {
            private readonly AppDbContext _context;

            public UserRequestService()
            {
                _context = new AppDbContext();
            }

            public bool EmailExists(string email)
            {
                return _context.Users.Any(u => u.Email == email)
                    || _context.UserRequests.Any(r => r.Email == email);
            }

            public void AddRequest(UserRequest request)
            {
                _context.UserRequests.Add(request);
                _context.SaveChanges();
            }
        public List<UserRequest> GetAllRequests()
        {
            return _context.UserRequests.Where(r => r.Status == "Pending").ToList();
        }

        public void ApproveRequest(int requestId)
        {
            var req = _context.UserRequests.FirstOrDefault(r => r.ID == requestId);
            if (req != null)
            {
                req.Status = "Approved";
                req.IsAccountCreated = true;
                _context.SaveChanges();
            }
        }
        public void DenyRequest(int id)
        {
            var req = _context.UserRequests.FirstOrDefault(r => r.ID == id);
            if (req != null)
            {
                req.Status = "Denied";
                _context.SaveChanges();
            }
        }
    }
    
}
