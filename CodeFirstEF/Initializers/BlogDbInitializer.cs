using System;
using System.Collections.Generic;
using System.Data.Entity;
using EntityFramework.Models;

namespace EntityFramework.Initializers
{
    public class BlogDbInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            IList<Post> posts = new List<Post>();
            posts.Add(new Post() { Id = Guid.NewGuid(), Title = "nice"});
            posts.Add(new Post() { Id = Guid.NewGuid(), Title = "does" });
            posts.Add(new Post() { Id = Guid.NewGuid(), Title = "it" });
            posts.Add(new Post() { Id = Guid.NewGuid(), Title = "work" });
            posts.Add(new Post() { Id = Guid.NewGuid(), Title = "maybe" });
            context.Posts.AddRange(posts);
            base.Seed(context);
        }
    }
}