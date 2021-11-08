using System;
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

        [HttpGet]
        public NewsResult Get()
        {
            var result = new NewsResult(Guid.NewGuid(), "google.com", Guid.NewGuid());
            return result;
        }
    }
}