using DPA202302ParcialCaso0322102058.Data;
using DPA202302ParcialCaso0322102058.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DPA202302ParcialCaso0322102058.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController : ControllerBase
    {
        private readonly ITerritoryRepository _territoryRepository;
        public TerritoryController(ITerritoryRepository territoryRepository)
        {
            _territoryRepository = territoryRepository;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Territory territory)
        {
            var result = await _territoryRepository.Insert(territory);
            if (!result)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpDelete("Delete/{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _territoryRepository.Delete(id);
            if (!result)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _territoryRepository.GetAll();
            return Ok(categories);


        }
    }
}
