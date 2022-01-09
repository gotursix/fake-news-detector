using System;
using System.Collections.Generic;
using System.Linq;
using API.Controllers;
using EntityFramework.Models;
using NUnit.Framework;


namespace UnitTests
{ 
    public class ApiTests
    {
        [Test]
        public void GetAllNewsResult_ShouldReturnAllNewsResult()
        {
            IList<NewsResult> results = new List<NewsResult>();
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "google.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "youtube.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "facebook.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            results.Add(new NewsResult() {Id = Guid.NewGuid(), Link = "instagram.com", Decision = "Real", SearchDate = RandomDay(), StatisticsId = Guid.NewGuid()});
            var controller = new ResultsHistoryController();
            if (controller.Get() is List<NewsResult> resultDb) Assert.AreEqual(results.Count, resultDb.Count);
        }
        
        [Test]
        public void Get_Result_For_Specific_Url()
        {
            var controller = new NewsResultController();
            var urlModel = new UrlModel
            {
                Url = "https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/"
            };
            var decision = controller.Post(urlModel).Decision;
            Assert.AreEqual("true ", decision);
        }
        
        [Test]
        public void Get_Result_For_User_Post()
        {
            var controller = new UsersController();
            var decision = controller.Post("https://www.infowars.com/posts/video-biden-self-owns-on-inflation-when-explaining-rising-meat-prices/");
            Assert.AreEqual(typeof(Microsoft.AspNetCore.Mvc.OkResult), decision.GetType());
        }
        
        [Test]
        public void Get_All_Users()
        {
            IEnumerable<User> users = new List<User>();
            var controller = new UsersController();
            Assert.AreEqual(users.Count(), controller.Get().Count());
        }
        
        private static DateTime RandomDay()
        {
            var start = new DateTime(1995, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(3);
        }
    }
}