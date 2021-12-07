using System;
using EntityFramework.Models;

namespace EntityFramework
{
    class Program
    {
        static void Main()
        {
            using (var ctx = new AppDbContext())
            {
                var post = new Post() { Id = Guid.NewGuid(), Title = "Nice" , Body = "Some text"};
                var user = new User() {Id = Guid.NewGuid(), Username = "cristi"};
                var user2 = new User() {Id = Guid.NewGuid(), Username = "vali"};
                ctx.Posts.Add(post);
                ctx.Users.Add(user);
                ctx.Users.Add(user2);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
        }
    }
}