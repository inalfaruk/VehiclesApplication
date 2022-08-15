using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
 
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }
        [HttpPost("delete")]
        public string Delete(Car car)
        {
            return _carService.DeleteByCarId(car);
        }

        [HttpPost("headlights")]
        public string HeadLightsSwitch(int id, bool key)
        {
            return _carService.HeadLightSwitch(id,key);
        }



    }
}
