using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;


namespace WebSignupApi
{
    [Route("api/[controller]")]
    public class RegisterationController : Controller
    {
        private IRegistrationService _registrationService;
        private readonly ILogger _logger;

        public RegisterationController(IRegistrationService registrationService, ILogger<RegisterationController> logger)
        {
            _registrationService = registrationService;
            _logger = logger;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Register([FromBody]Signup value)
        {
            try
            {
                _registrationService.SignupUser(value);
                return Accepted();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"Registration failed");
                return BadRequest();
            }
        }

        // POST api/<controller>
        [HttpPost]
        public void Verify([FromBody]UserEmailVerification value)
        {
            _registrationService.VerifyRegisteration(value);
        }

        // POST api/<controller>
        [HttpPost]
        public void Complete([FromBody]UserProfile value)
        {
            _registrationService.CompleteRegistration(value);
        }


    }
}
