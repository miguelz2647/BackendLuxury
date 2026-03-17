using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Business.Services;
using ExcelsiorLuxury.Data.Entities;
using Microsoft.AspNetCore.Mvc;


namespace ExcelsiorLuxury.API.Controllers
{
    [ApiController]
    [Route("api/Modelo")]
    public class ModeloController : ControllerBase
    {
        private readonly IModeloService _modeloService;

        public ModeloController(IModeloService modeloService)
        {
            _modeloService = modeloService;
        }
        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _modeloService.GetAllAsync());

        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _modeloService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZModelo modelo) =>
            Ok(await _modeloService.AddAsync(modelo));

        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZModelo modelo)
        {
            var updated = await _modeloService.UpdateAsync(modelo);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
        {
            var deleted = await _modeloService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
