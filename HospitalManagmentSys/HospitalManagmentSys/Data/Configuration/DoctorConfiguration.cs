using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HospitalManagmentSys.Data.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Specialty).IsRequired().HasMaxLength(30);

            builder.HasOne(d => d.Department).WithMany(dep => dep.Doctors)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.User)       
           .WithOne(u => u.Doctor)                    
           .HasForeignKey<Doctor>(d=>d.UserId)
           .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.TimeSlots).WithOne(t => t.Doctor)
                   .HasForeignKey(t => t.DoctorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.Appointments).WithOne(a => a.Doctor)
                   .HasForeignKey(a => a.DoctorId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
