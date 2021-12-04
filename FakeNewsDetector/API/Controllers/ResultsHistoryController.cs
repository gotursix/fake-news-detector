using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework;
using EntityFramework.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultsHistoryController : ControllerBase
    {
        // TODO: remove later
        private readonly List<Post> _postResultHistory = new();
        
        private readonly List<NewsResult> _newsResultHistory = new();
        private readonly List<URL> _sitesList = new();
        private readonly ILogger<NewsResult> _logger;
        private Random gen = new Random();
        
        public ResultsHistoryController(ILogger<NewsResult> logger)
        {
            _logger = logger;
            _sitesList.Add(new URL("google.com"));
            _sitesList.Add(new URL("youtube.com"));
            _sitesList.Add(new URL("facebook.com"));
            _sitesList.Add(new URL("instagram.com"));
            
        }
        
        DateTime RandomDay()
        {
            var start = new DateTime(1995, 1, 1);
            var range = (DateTime.Today - start).Days;           
            return start.AddDays(gen.Next(range));
        }
        
        // TODO : Fix logic
        [EnableCors]
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            /*foreach (var result in _sitesList.Select(site => new NewsResult(Guid.NewGuid(), site, Guid.NewGuid(), "Real", RandomDay())))
            {
                _newsResultHistory.Add(result);
            }*/
            
            using (var ctx = new AppDbContext())
            {
                var query = from p in ctx.Posts
                    orderby p.Id
                    select p;
                foreach (var p in query)
                {
                    _postResultHistory.Add(p);
                    _postResultHistory.Add(p);
                }
            }
            return _postResultHistory;
        }
    }
}