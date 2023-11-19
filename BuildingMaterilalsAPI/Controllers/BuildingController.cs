using BuildingMaterilals.Web.DTOs;
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
        public async ValueTask<IActionResult> GetAllMaterialAsync()
        {
            var result = await materialRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateMaterialAsync(MaterialDTO materialDTO)
        {
            var result = await materialRepository.CreateAsync(materialDTO);
            return Ok(result);
        }

    }
}
