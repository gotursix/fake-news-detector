using System;

namespace EntityFramework.Models
{
    public class NewsResult
    {
        public Guid Id { get; set; }
        public string Link { get; set; }
        public string Decision { get; set; }
        public DateTime SearchDate { get; set; }
        public Guid StatisticsId { get; set; }
    }
}