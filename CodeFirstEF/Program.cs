using System;
using EntityFramework.Models;

namespace EntityFramework
{
    static class Program
    {
        static void Main()
        {
            using (var ctx = new AppDbContext())
            {
                var user = new User() {Id = Guid.NewGuid(), Username = "cristi"};
                var user2 = new User() {Id = Guid.NewGuid(), Username = "vali"};
                ctx.Users.Add(user);
                ctx.Users.Add(user2);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
        }
    }
}