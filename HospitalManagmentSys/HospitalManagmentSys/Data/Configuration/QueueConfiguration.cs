using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.Data.Configuration
{
    
    public class QueueConfiguration :IEntityTypeConfiguration<Queue>
    {
        public void Configure(EntityTypeBuilder<Queue> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Status).HasConversion<string>().IsRequired();

            builder.Property(e => e.LastUpdated).HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.TimeSlotId).IsRequired();

            builder.HasMany<Appointment>(e => e.Appointments)
                .WithOne(e => e.Queue).HasForeignKey(e => e.QueueId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<TimeSlot>(e=>e.TimeSlot).WithOne(e=>e.Queue)
                .HasForeignKey<Queue>(e=>e.TimeSlotId)
                .OnDelete(DeleteBehavior.Restrict); 
        }

    }
}
