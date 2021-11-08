using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultsHistoryController : ControllerBase
    {
        private readonly List<NewsResult> _newsResultHistory = new();
        private readonly List<string> _sitesList = new();
        private readonly ILogger<NewsResult> _logger;
        
        public ResultsHistoryController(ILogger<NewsResult> logger)
        {
            _logger = logger;
            _sitesList.Add("google.com");
            _sitesList.Add("youtube.com");
            _sitesList.Add("facebook.com");
            _sitesList.Add("instagram.com");
            
        }

        [HttpGet]
        public IEnumerable<NewsResult> Get()
        {
            foreach (var result in _sitesList.Select(site => new NewsResult(Guid.NewGuid(), site, Guid.NewGuid())))
            {
                _newsResultHistory.Add(result);
            }

            return _newsResultHistory;
        }
    }
}