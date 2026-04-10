using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.Data.Configuration
{
    
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e=>e.Id);
            builder.Property(d => d.Phone).IsRequired().HasMaxLength(11);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e => e.PasswordHash).IsRequired().HasMaxLength(30);

            builder.HasOne<Doctor>(e => e.Doctor).WithOne(e => e.User)
                .HasForeignKey<Doctor>(e=>e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne<UserRequest>(e=>e.UserRequest).WithOne(e => e.User)
                .HasForeignKey<UserRequest>(e=>e.UserID)
                .OnDelete(DeleteBehavior.Cascade);  
        }
      
    }
}
