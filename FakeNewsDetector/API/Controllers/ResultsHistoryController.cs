using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultsHistoryController : ControllerBase
    {
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
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;           
            return start.AddDays(gen.Next(range));
        }
        
        [EnableCors]
        [HttpGet]
        public IEnumerable<NewsResult> Get()
        {
            foreach (var result in _sitesList.Select(site => new NewsResult(Guid.NewGuid(), site, Guid.NewGuid(), "Real", RandomDay())))
            {
                _newsResultHistory.Add(result);
            }

            return _newsResultHistory;
        }
    }
}