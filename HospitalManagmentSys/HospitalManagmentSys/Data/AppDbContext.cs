using Microsoft.EntityFrameworkCore;
using HospitalManagmentSys.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSys.Data
{
    public class AppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DepartmentConfiguration).Assembly);
        }
    }
}
