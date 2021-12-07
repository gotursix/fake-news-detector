using System;
using System.Collections.Generic;
using System.Data.Entity;
using EntityFramework.Models;

namespace EntityFramework.Initializers
{
    public class UsersDbInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            IList<User> usersList = new List<User>();
            usersList.Add(new User() {Id = Guid.NewGuid(), Username = "username1"});
            usersList.Add(new User() {Id = Guid.NewGuid(), Username = "username2"});
            usersList.Add(new User() {Id = Guid.NewGuid(), Username = "username3"});
            context.Users.AddRange(usersList);
            base.Seed(context);
        }
    }
}