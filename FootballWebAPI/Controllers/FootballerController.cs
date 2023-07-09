using BusinessLayer;
using DataAccessLayer;
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
        private readonly IFootballerService _footballerService;

        public FootballerController(IFootballerService footballerService, ILogger<FootballerController> logger)
        {
            _footballerService = footballerService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Footballer> GetAllFootballers()
        {
            return _footballerService.GetAllFootballer();  
        }

        [HttpGet("{id}")]
        public Footballer GetFootballerById(Guid id)
        {
            return _footballerService.GetFootballerById(id);
        }

        [HttpPost]
        public IActionResult AddFootballer(Footballer footballer)
        {

            try 
            {
                var result = _footballerService.AddFootballer(footballer);

                return Created(result.ToString(), footballer);
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public bool UpdateFootballer(Guid id, Footballer footballer)
        {
            footballer.Id = id;
            return _footballerService.UpdateFootballer(footballer);
        }

        [HttpDelete("{id}")]
        public bool DeleteFootballer(Guid id)
        {
            return _footballerService.DeleteFootballerById(id);
        }
    }
}
