using System;
using EntityFramework;
using EntityFramework.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsResultController : ControllerBase
    {
        private readonly ILogger<NewsResult> _logger;

        public NewsResultController(ILogger<NewsResult> logger)
        {
            _logger = logger;
        }
        
        [EnableCors]
        [HttpPost]
        public NewsResult Post(string url)
        {
            var result = new NewsResult(){Id = Guid.NewGuid(), Decision = "Real",SearchDate = DateTime.Now, StatisticsId = Guid.NewGuid(),Link = url};
            using var ctx = new AppDbContext();
            ctx.ResultsHistory.Add(result);
            ctx.SaveChanges();
            return result;
        }
    }
}