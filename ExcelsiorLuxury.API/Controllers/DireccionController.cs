using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExcelsiorLuxury.API.Controllers
{

    [ApiController]
    [Route("api/direccion")]
    public class DireccionesController : ControllerBase
    {
        private readonly IDireccionService _direccionService;

        public DireccionesController(IDireccionService direccionService)
        {
            _direccionService = direccionService;
        }

        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _direccionService.GetAllAsync());

        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _direccionService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZDireccion direccion) =>
            Ok(await _direccionService.AddAsync(direccion));

        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZDireccion direccion)
        {
            var updated = await _direccionService.UpdateAsync(direccion);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
        {
            var deleted = await _direccionService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
