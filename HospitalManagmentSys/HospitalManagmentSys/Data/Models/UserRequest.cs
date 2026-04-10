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
        public int UserID { get; set; }

        public string Status { get; set; }

        public DateTime RequestDate { get; set; }

        public bool IsAccountCreated { get; set; }


        public User user { get; set; }
        public UserRequest()
        {
            
        }
        public UserRequest(User user, string Status, DateTime RequestDate, bool? IsAccountCreated)
        {
            this.user = user;
            this.Status = Status;
            this.RequestDate = RequestDate;
            this.IsAccountCreated = IsAccountCreated ?? false;


        }

    }
}
