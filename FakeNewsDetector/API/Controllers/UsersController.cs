using System;
using System.Collections.Generic;
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
            _usersList.Add(new User(Guid.NewGuid(), "username1", new URL("www.google.com")));
            _usersList.Add(new User(Guid.NewGuid(), "username2", new URL("www.youtube.com")));
            _usersList.Add(new User(Guid.NewGuid(), "username3", new URL("www.facebook.com")));
        }
        
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _usersList;
        }
        
        [HttpPost]
        public ActionResult Post(URL url)
        {
            _usersList.Add(new User(Guid.NewGuid(), "lol", url));
            return Ok();
        }
    }
}