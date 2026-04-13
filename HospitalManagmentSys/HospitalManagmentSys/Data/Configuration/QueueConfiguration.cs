using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.Data.Configuration
{
    
    public class QueueConfiguration :IEntityTypeConfiguration<Queue>
    {
        public void Configure(EntityTypeBuilder<Queue> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Status).HasConversion<string>().IsRequired();

            builder.Property(e => e.LastUpdated).HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.DoctorId).IsRequired();

            builder.HasMany<Appointment>(e => e.Appointments)
                .WithOne(e => e.Queue).HasForeignKey(e => e.QueueId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Doctor>(q => q.Doctor)
                .WithMany(d => d.Queues)
                .HasForeignKey(q => q.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);



        }

    }
}
