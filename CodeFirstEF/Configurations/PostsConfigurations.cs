using System.Data.Entity.ModelConfiguration;
using EntityFramework.Models;

namespace EntityFramework.Configurations
{
    public class PostsConfigurations : EntityTypeConfiguration<Post>
    {
        public PostsConfigurations()
        {
            this.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(50);

            /*this.Property(s => s.StudentName)
                .IsConcurrencyToken();*/

            // Configure a one-to-one relationship between Student & StudentAddress
            /*this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
                .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).*/
        }
    }
}