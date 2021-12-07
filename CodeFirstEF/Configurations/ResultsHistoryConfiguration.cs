using System.Data.Entity.ModelConfiguration;
using EntityFramework.Models;

namespace EntityFramework.Configurations
{
    public class ResultsHistoryConfiguration : EntityTypeConfiguration<NewsResult>
    {
        public ResultsHistoryConfiguration()
        {
            this.Property(p => p.Decision)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}