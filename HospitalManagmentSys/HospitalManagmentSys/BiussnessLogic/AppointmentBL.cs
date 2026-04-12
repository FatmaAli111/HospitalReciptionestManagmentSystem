using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.BiussnessLogic
{
    class AppointmentBL
    {
        private readonly AppDbContext _context;
        public AppointmentBL()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.Include(d=>d.User);
        }
        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients;
        }
    }
}
