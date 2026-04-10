using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.Data.Configuration
{
   
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e=>e.FullName).HasMaxLength(30).IsRequired();
            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e=>e.Phone).HasMaxLength(11).IsRequired();
            builder.Property(e => e.NoShowCount).HasDefaultValue(0);
            builder.Property(e => e.DateOfBirth).IsRequired();
            builder.Property(e => e.AttendanceRate).HasDefaultValue(0.0);
            builder.Property(e => e.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.BloodType).HasConversion<string>().HasMaxLength(15).IsRequired();
            builder.Property(e => e.Gender).HasConversion<string>().IsRequired();
            builder.Property(e => e.MedicalUrgency).HasConversion<string>().IsRequired();

            builder.HasMany<Appointment>(e=>e.Appointments).WithOne(e=>e.Patient)
                .HasForeignKey(e=>e.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
