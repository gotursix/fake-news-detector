using System;
using System.Collections.Generic;
using API.Controllers;
using EntityFramework.Models;
using NUnit.Framework;


namespace UnitTests
{ 
    public class ApiTests
    {
        private DateTime RandomDay()
        {
            var start = new DateTime(1995, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(3);
        }
        [Test]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            IList<NewsResult> results = new List<NewsResult>();
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "google.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "youtube.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "facebook.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "instagram.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            var controller = new ResultsHistoryController();
            if (controller.Get() is List<NewsResult> resultDb) Assert.AreEqual(results.Count, resultDb.Count);
        }
    }
}