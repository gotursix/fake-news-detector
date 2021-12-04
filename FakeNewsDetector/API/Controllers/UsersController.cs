using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly List<User> _usersList = new();
        private readonly ILogger<User> _logger;

        public UsersController(ILogger<User> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using (var ctx = new AppDbContext())
            {
                var query = from u in ctx.Users
                    orderby u.Username
                    select u;
                foreach (var u in query)
                {
                    _usersList.Add(u);
                }
            }
            return _usersList;
        }
        
        [HttpPost]
        public ActionResult Post(URL url)
        {
            // TODO: Finish function
            //_usersList.Add(new User(Guid.NewGuid(), "lol", url));
            //_usersList.Add(new User(Guid.NewGuid(), "lol"));
            return Ok();
        }
    }
}