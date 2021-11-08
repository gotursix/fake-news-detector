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
            _usersList.Add(new User(Guid.NewGuid(), "username1"));
            _usersList.Add(new User(Guid.NewGuid(), "username2"));
            _usersList.Add(new User(Guid.NewGuid(), "username3"));
        }
        
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _usersList;
        }
        
        [HttpPost]
        public bool Post(string username)
        {
            _usersList.Add(new User(Guid.NewGuid(), username));
            return true;
        }
    }
}