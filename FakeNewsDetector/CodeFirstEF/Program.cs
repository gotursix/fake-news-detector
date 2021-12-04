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
                var post = new Post() { Id = 69, Title = "leeeeeeeeeeeroy"};

                ctx.Posts.Add(post);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();        
        }
    }
}