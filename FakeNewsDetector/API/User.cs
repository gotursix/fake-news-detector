using System;
using API.Controllers;

namespace API
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public User(Guid id, string username, URL url)
        {
            Id = id;
            Username = username;
            Console.WriteLine(url.url);
        }
    }
}