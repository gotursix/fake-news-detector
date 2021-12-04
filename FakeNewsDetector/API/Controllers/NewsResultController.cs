using System;
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
        public NewsResult Post(URL url)
        {
            var result = new NewsResult(Guid.NewGuid(), url, Guid.NewGuid(), "Real", DateTime.Now);
            return result;
        }
    }
}