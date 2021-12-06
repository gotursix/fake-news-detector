using System;

namespace EntityFramework.Models
{
    public partial class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}