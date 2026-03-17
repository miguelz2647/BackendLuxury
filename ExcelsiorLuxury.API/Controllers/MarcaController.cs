using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExcelsiorLuxury.API.Controllers
{

    [ApiController]
    [Route("api/Marca")]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaService _marcaService;

        public MarcaController(IMarcaService marcaService)
        {
            _marcaService = marcaService;
        }

        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _marcaService.GetAllAsync());

        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _marcaService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZMarca marca) =>
            Ok(await _marcaService.AddAsync(marca));

        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZMarca marca)
        {
            var updated = await _marcaService.UpdateAsync(marca);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
        {
            var deleted = await _marcaService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
