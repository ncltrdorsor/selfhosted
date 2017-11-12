using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfHosted.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly Configuration _options;

        public HomeController(IOptions<Configuration> optionsAccessor)
        {
            _options = optionsAccessor.Value;
        }

        [HttpGet]
        [Route("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Ok(_options.WelcomeMessage);
        }
    }
}
