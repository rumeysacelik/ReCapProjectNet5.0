using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Hosting;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private Car _car { get; set; }
        private IWebHostEnvironment _environment;
        private ICarService _carService;

        public CarsController(IWebHostEnvironment environment, ICarService carService)
        {
            _environment = environment;
            _carService = carService;
        }

        [HttpPost("postCarAdd")]
        public IActionResult postCarAdd(Car _car)
        {
            var result = _carService.Add(_car);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getCarAll")]
        public IActionResult getCarAll()
        {
            var result = _carService.GetAllCars();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
