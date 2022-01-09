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
    public class UsersController : ControllerBase
    {
        public UsersController(ILogger<User> logger)
        {
            
        }

        public UsersController()
        {
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using var ctx = new AppDbContext();
            var query = from u in ctx.Users
                orderby u.Id
                select u;
            return query.ToList();
        }
        
        [HttpPost]
        public ActionResult Post(string url)
        {
            return Ok();
        }
    }
}