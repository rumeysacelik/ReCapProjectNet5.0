using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private CarImage _carImage;
        private ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("postCarImageUpdate")]
        public IActionResult putCarImageUpdate([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            _carImage=new CarImage
            {
                CarId = Id,
                Image = file.FileName,
                Date = DateTime.Now,
            };
            var result = _carImageService.Update(_carImage);
            return Ok();
        }
    }
}
