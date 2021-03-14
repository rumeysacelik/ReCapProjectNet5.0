using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getrentaldetaillist")]
        public IActionResult GetRentalDetailList()
        {
            var results = _rentalService.GetRentalDetails();
            if (results.Success)
            {
                return Ok(results);
            }

            return BadRequest(results);
        }
    }
}