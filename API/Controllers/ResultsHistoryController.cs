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
        private readonly ILogger<NewsResult> _logger;
        
        public ResultsHistoryController(ILogger<NewsResult> logger)
        {
            _logger = logger;
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<NewsResult> Get()
        {
            using var ctx = new AppDbContext();
            var query = from r in ctx.ResultsHistory
                orderby r.Id
                select r;
            return query.ToList();
        }
    }
}