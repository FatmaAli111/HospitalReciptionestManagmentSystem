using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentSys.Data.Configuration
{

    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.QueueOrder).IsRequired();
            builder.Property(e => e.PriorityScore).IsRequired();

            builder.Property(e => e.Status).HasConversion<string>().HasDefaultValue(AppointmentStatus.Pending).IsRequired();

            builder.HasOne<Patient>(e=>e.Patient).WithMany(e=>e.Appointments)
                .HasForeignKey(e=>e.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Doctor>(e => e.Doctor).WithMany(e => e.Appointments)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<TimeSlot>(e => e.TimeSlot).WithMany(e => e.Appointments)
                .HasForeignKey(e => e.TimeSlotId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Queue>(e => e.Queue).WithMany(e => e.Appointments)
                .HasForeignKey(e => e.QueueId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Attendance>(e => e.Attendance).WithOne(e => e.Appointment)
                    .HasForeignKey<Attendance>(e => e.AppointmentID)
                    .OnDelete(DeleteBehavior.Restrict);
        
        }
    }
}
