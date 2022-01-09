using System.Data.Entity;
using System.Data.SqlClient;
using EntityFramework.Configurations;
using EntityFramework.Initializers;
using EntityFramework.Models;

namespace EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("mssql")
        {
            SqlConnection.ClearAllPools();
            Database.SetInitializer<AppDbContext>(new UsersDbInitializer());
            Database.SetInitializer<AppDbContext>(new ResultsHistoryInitializer());
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsersConfigurations());
            modelBuilder.Configurations.Add(new ResultsHistoryConfiguration());
            modelBuilder.Entity<User>()
                .ToTable("Users");
            modelBuilder.Entity<NewsResult>()
                .ToTable("ResultsHistory");
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<NewsResult> ResultsHistory { get; set; }
    }
}