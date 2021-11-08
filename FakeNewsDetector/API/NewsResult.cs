using System;

namespace API
{
    public class NewsResult
    {
        public Guid Id { get; set; }
        public string Link { get; set; }
        public Guid StatisticsId { get; set; }

        public NewsResult(Guid id, string link, Guid statisticsId)
        {
            Id = id;
            Link = link;
            StatisticsId = statisticsId;
        }
    }
}