using System.Data.Entity.ModelConfiguration;
using EntityFramework.Models;

namespace EntityFramework.Configurations
{
    public class UsersConfigurations : EntityTypeConfiguration<User>
    {
        public UsersConfigurations()
        {
            this.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}