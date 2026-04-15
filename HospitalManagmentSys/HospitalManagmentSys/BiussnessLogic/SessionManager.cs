using HospitalManagmentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
    
        public static class SessionManager
        {
            public static User CurrentUser { get; set; }
        }
    
}
