using System.Data.Entity;
using EntityFramework.Configurations;
using EntityFramework.Initializers;
using EntityFramework.Models;

namespace EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("mssql")
        {
            Database.SetInitializer<AppDbContext>(new BlogDbInitializer());
            Database.SetInitializer<AppDbContext>(new UsersDbInitializer());
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new PostsConfigurations());
            modelBuilder.Configurations.Add(new UsersConfigurations());

            modelBuilder.Entity<Post>()
                .ToTable("PostsInfo");
            modelBuilder.Entity<User>()
                .ToTable("Users");
            modelBuilder.Entity<NewsResult>()
                .ToTable("NewsResults");

            /*modelBuilder.Entity<Teacher>()
                .MapToStoredProcedures();*/
        }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}