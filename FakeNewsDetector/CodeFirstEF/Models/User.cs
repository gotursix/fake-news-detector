using System;
using API.Controllers;

namespace EntityFramework.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        /*public User(Guid id, string username, URL url)
        {
            Id = id;
            Username = username;
            Console.WriteLine(url.url);
        }*/
    }
}