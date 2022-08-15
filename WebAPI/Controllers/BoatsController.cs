using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatsController : ControllerBase
    {
        IBoatService _boatService;

        public BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("getall")]
        public List<Boat> GetAll()
        {
            return _boatService.GetAll();
        }

        [HttpGet("getallbycolorname")]
        public List<Boat> GetAllByColorName(string colorName)
        {
            return _boatService.GetAllByColorName(colorName);
        }

    }
}
