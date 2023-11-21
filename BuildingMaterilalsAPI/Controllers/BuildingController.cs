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

        [HttpGet]
        public async ValueTask<IActionResult> GetMaterialByName(string name)
        {
            var result = await materialRepository.GetByNameAsync(name);
            return Ok(result);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateMaterialAsync(MaterialDTO materialDTO)
        {
            var result = await materialRepository.CreateAsync(materialDTO);
            return Ok(result);
        }

        [HttpPatch]
        public async ValueTask<IActionResult> UpdateMaterialAsync(string name, MaterialDTO materialDTO)
        {
            var result = await materialRepository.UpdateAsync(name, materialDTO);
            return Ok(result);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteMaterialAsync(string name)
        {
            var result = await materialRepository.DeleteAsync(name);
            return Ok(result);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetCountAsync()
        {
            int result = await materialRepository.GetCountAsync();
            return Ok(result);
        }
    }
}
