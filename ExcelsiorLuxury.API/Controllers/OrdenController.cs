using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Data.Repositories;
using ExcelsiorLuxury.Data.Repositories.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExcelsiorLuxury.API.Controllers
{


    [ApiController]
    [Route("api/Orden")]
    public class OrdenController : ControllerBase
    {
        private readonly IOrdenService _OrdenService;
        public OrdenController(IOrdenService ordenService)
        {
            _OrdenService = ordenService;
        }


        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _OrdenService.GetAllAsync());

        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _OrdenService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZOrden orden) =>
            Ok(await _OrdenService.AddAsync(orden));

        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZOrden orden)
        {
            var updated = await _OrdenService.UpdateAsync(orden);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
        {
            var deleted = await _OrdenService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }



    }
}
