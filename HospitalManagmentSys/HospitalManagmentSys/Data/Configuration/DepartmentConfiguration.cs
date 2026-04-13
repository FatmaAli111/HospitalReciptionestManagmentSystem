
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentSys.Data.Configuration
{

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(d => d.Id);
            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(20);
            builder.HasMany<Doctor>(e=>e.Doctors).WithOne(e=>e.Department).HasForeignKey(d=>d.DepartmentId).OnDelete(DeleteBehavior.Restrict);

    }
    }
}
