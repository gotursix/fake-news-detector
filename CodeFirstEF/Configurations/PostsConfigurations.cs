using System.Data.Entity.ModelConfiguration;
using EntityFramework.Models;

namespace EntityFramework.Configurations
{
    public class PostsConfigurations : EntityTypeConfiguration<Post>
    {
        public PostsConfigurations()
        {
            Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}