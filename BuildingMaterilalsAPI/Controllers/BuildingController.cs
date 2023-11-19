using BuildingMaterilals.Web.Repositories.Materials;
using Microsoft.AspNetCore.Mvc;

namespace BuildingMaterilalsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IMaterialRepository materialRepository;

        public BuildingController(IMaterialRepository _materialRepository)
        {
            this.materialRepository = _materialRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = materialRepository.GetAllAsync();
            return Ok(result);
        }
    }
}
