using System;
using System.Collections.Generic;
using System.Data.Entity;
using EntityFramework.Models;

namespace EntityFramework.Initializers
{
    public class ResultsHistoryInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            IList<NewsResult> results = new List<NewsResult>();
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "google.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "youtube.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "facebook.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "instagram.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            context.ResultsHistory.AddRange(results);
            base.Seed(context);
        }

        private static DateTime RandomDay()
        {
            var start = new DateTime(1995, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(3);
        }
    }
}
