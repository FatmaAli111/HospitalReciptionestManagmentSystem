using global::HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentSys.Data.Configuration
{
    public class TimeSlotConfiguration : IEntityTypeConfiguration<TimeSlot>
    {
        public void Configure(EntityTypeBuilder<TimeSlot> builder)
        {

            builder.HasKey(e => e.Id);
            builder.Property(e => e.SlotDate).IsRequired();
            builder.Property(e => e.StartTime).IsRequired();
            builder.Property(e => e.EndTime).IsRequired();
            builder.Property(e => e.MaxCapacity).IsRequired();
            builder.Property(e => e.BookedCount).HasDefaultValue(0);
            builder.Property(e => e.IsAvailable).HasDefaultValue(true);

            builder.HasOne(e => e.Doctor).WithMany(d => d.TimeSlots)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Appointments).WithOne(e => e.TimeSlot)
                  .HasForeignKey(e => e.TimeSlotId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Queue).WithOne(e => e.TimeSlot)
                   .HasForeignKey<Queue>(e => e.TimeSlotId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
