using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Entities;
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
        public async Task<IEnumerable<Footballer>> GetAllFootballers()
        {
            return await _footballerService.GetAllFootballer();  
        }

        [HttpGet("{id}")]
        public async Task<Footballer> GetFootballerById(Guid id)
        {
            return await _footballerService.GetFootballerById(id);
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
        public async Task<IActionResult> UpdateFootballer(Guid id, Footballer footballer)
        {
            footballer.Id = id;

            var result = await _footballerService.UpdateFootballer(footballer);
            return result ? StatusCode(200) : StatusCode(400); 
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteFootballer(Guid id)
        {
            return await _footballerService.DeleteFootballerById(id);
        }
    }
}
