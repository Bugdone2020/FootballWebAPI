using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballerController : ControllerBase
    {
        private readonly ILogger<FootballerController> _logger;

        public FootballerController(ILogger<FootballerController> logger)
        {
            _logger = logger;
        }

        
    }
}
