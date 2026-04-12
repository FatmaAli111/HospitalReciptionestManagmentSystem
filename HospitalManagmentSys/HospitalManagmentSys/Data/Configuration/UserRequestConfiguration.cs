using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HospitalManagmentSys.Data.Models;
namespace HospitalManagmentSys.Data.Configuration
{
    internal class UserRequestConfiguration: IEntityTypeConfiguration<UserRequest>
    {
        public void Configure(EntityTypeBuilder<UserRequest> builder)
        {
            builder.HasKey(e => e.ID);

            builder.Property(e => e.Status).IsRequired().HasMaxLength(20);
            builder.Property(e => e.RequestDate).HasDefaultValueSql("GETDATE()"); 

            builder.Property(e => e.IsAccountCreated).HasDefaultValue(false);

            builder.HasOne(e => e.User).WithOne(e => e.UserRequest)
                   .HasForeignKey<UserRequest>(e => e.UserID)
                   .OnDelete(DeleteBehavior.Cascade);
        }

    }

}

