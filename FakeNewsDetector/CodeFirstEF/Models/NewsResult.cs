using System;
using API.Controllers;

namespace EntityFramework.Models
{
    public class NewsResult
    {
        public Guid Id { get; set; }
        public URL Link { get; set; }
        public string Decision { get; set; }
        public DateTime SearchDate { get; set; }
        public Guid StatisticsId { get; set; }

        public NewsResult(Guid id, URL link, Guid statisticsId, string decision, DateTime date)
        {
            Decision = decision;
            SearchDate = date;
            Id = id;
            Link = link;
            StatisticsId = statisticsId;
        }
    }
}