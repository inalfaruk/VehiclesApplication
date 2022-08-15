using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussesController : ControllerBase
    {
        IBusService _busService;

        public BussesController(IBusService busService)
        {
            _busService = busService;
        }
        [HttpGet("getall")]
        public List<Bus> GetAll()
        {
            return _busService.GetAll();
        }

        [HttpGet("getallbycolorname")]
        public List<Bus> GetAllByColorName(string colorName)
        {
            return _busService.GetAllByColorName(colorName);
        }

    }
}
