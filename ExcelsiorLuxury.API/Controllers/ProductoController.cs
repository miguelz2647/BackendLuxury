using ExcelsiorLuxury.Business.Dtos;
using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExcelsiorLuxury.API.Controllers
{
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _ProductoService;
        public ProductoController(IProductoService productoService)
        {
            _ProductoService = productoService;
        }



        [HttpGet("todos")]
        public async Task<IActionResult> GetAll() => Ok(await _ProductoService.GetAllAsync());



        [HttpPost("obtener")]
        public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
        {
            var direccion = await _ProductoService.GetByIdAsync(dto.Id);
            if (direccion == null) return NotFound();
            return Ok(direccion);
        }



        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] ZProducto producto) =>
            Ok(await _ProductoService.AddAsync(producto));



        [HttpPut("actualizar")]
        public async Task<IActionResult> Update([FromBody] ZProducto producto)
        {
            var updated = await _ProductoService.UpdateAsync(producto);
            if (updated == null) return NotFound();
            return Ok(updated);
        }


        [HttpDelete("eliminar")]
        public async Task<IActionResult> Delete([FromBody] ZProducto dto)
        {
            var deleted = await _ProductoService.DeleteAsync(dto.Id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
