
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentSys.Data.Configuration
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.CheckInTime).IsRequired();
            builder.Property(e => e.CheckOutTime).IsRequired();
            builder.Property(e => e.ArriveTime).IsRequired();
            builder.Property(e => e.Status).HasConversion<string>().IsRequired();

            builder.HasOne(e => e.Appointment).WithOne(e => e.Attendance)
                .HasForeignKey<Attendance>(e => e.AppointmentID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }



}
