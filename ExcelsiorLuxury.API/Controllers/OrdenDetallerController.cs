using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Business.Services;
using ExcelsiorLuxury.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExcelsiorLuxury.API.Controllers
{

    [ApiController]
    [Route("api/OrdenDetalle")]
    public class OrdenDetallerController : ControllerBase
    {
        private readonly IOrdenDetalleService _ordenDetalleService;

        public OrdenDetallerController(IOrdenDetalleService ordenDetalleService)
        {
            _ordenDetalleService = ordenDetalleService;
        }



        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _ordenDetalleService.GetAllAsync());

        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _ordenDetalleService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZOrdenDetalle ordenDetalle) =>
            Ok(await _ordenDetalleService.AddAsync(ordenDetalle));

        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZOrdenDetalle ordenDetalle)
        {
            var updated = await _ordenDetalleService.UpdateAsync(ordenDetalle);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
        {
            var deleted = await _ordenDetalleService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }

    }
}
