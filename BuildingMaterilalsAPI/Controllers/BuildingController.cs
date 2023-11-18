using Microsoft.AspNetCore.Mvc;

namespace BuildingMaterilalsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Builing Controller");
        }
    }
}
