using System;

namespace EntityFramework.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}