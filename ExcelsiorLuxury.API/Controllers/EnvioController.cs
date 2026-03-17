using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExcelsiorLuxury.API.Controllers
{

    [ApiController]
    [Route("api/Envio")]
    public class EnvioController : ControllerBase 
    {
        private readonly IEnvioService _envioService;

        public EnvioController(IEnvioService envioService)
        {
            _envioService = envioService;
        }


        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _envioService.GetAllAsync());

        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _envioService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZEnvio envio) =>
            Ok(await _envioService.AddAsync(envio));

        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZEnvio envio)
        {
            var updated = await _envioService.UpdateAsync(envio);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
        {
            var deleted = await _envioService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
