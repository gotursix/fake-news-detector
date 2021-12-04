using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EntityFramework.Configurations;
using EntityFramework.Models;

namespace EntityFramework
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("mssql")
        {
            Database.SetInitializer<BlogDbContext>(new BlogDbInitializer());
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new PostsConfigurations());

            modelBuilder.Entity<Post>()
                .ToTable("PostsInfo");

            /*modelBuilder.Entity<Teacher>()
                .MapToStoredProcedures();*/
        }
        
        public DbSet<Post> Posts { get; set; }
    }
}