using Coderland_BackEnd_Challenge.Models;
using Coderland_BackEnd_Challenge.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coderland_BackEnd_Challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcasAutosController : ControllerBase
    {
        private readonly ICarBrandService _carBrandService;
        private readonly ILogger<MarcasAutosController> _logger;

        public MarcasAutosController(ICarBrandService carBrandService, ILogger<MarcasAutosController> logger)
        {
            _carBrandService = carBrandService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetMarcas()
        {
            try
            {
                var marcas = await _carBrandService.GetAllMarcasAsync();
                return Ok(marcas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving car brands");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMarca([FromBody] CarBrands marca)
        {
            if (marca == null)
            {
                return BadRequest("Marca cannot be null.");
            }

            try
            {
                var createdMarca = await _carBrandService.CreateMarcaAsync(marca);
                return CreatedAtAction(nameof(GetMarcas), new { id = createdMarca.Id }, createdMarca);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating car brand");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating data in the database.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMarca(int id, [FromBody] CarBrands marca)
        {
            if (id != marca.Id)
            {
                return BadRequest("Marca ID mismatch.");
            }

            try
            {
                var updated = await _carBrandService.UpdateMarcaAsync(marca);
                if (!updated)
                {
                    return NotFound("Marca not found.");
                }

                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating car brand");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data in the database.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarca(int id)
        {
            try
            {
                var deleted = await _carBrandService.DeleteMarcaAsync(id);
                if (!deleted)
                {
                    return NotFound("Marca not found.");
                }

                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting car brand");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data from the database.");
            }
        }
    }
}
