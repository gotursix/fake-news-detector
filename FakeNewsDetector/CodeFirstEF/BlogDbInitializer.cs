using System.Collections.Generic;
using System.Data.Entity;
using EntityFramework.Models;

namespace EntityFramework
{
    public class BlogDbInitializer : DropCreateDatabaseAlways<BlogDbContext>
    {
        protected override void Seed(BlogDbContext context)
        {
            IList<Post> posts = new List<Post>();

            posts.Add(new Post() { Id = 1, Title = "nice"});
            posts.Add(new Post() { Id = 1, Title = "does" });
            posts.Add(new Post() { Id = 1, Title = "it" });
            posts.Add(new Post() { Id = 1, Title = "work" });
            posts.Add(new Post() { Id = 1, Title = "maybe" });

            context.Posts.AddRange(posts);

            base.Seed(context);
        }
    }
}