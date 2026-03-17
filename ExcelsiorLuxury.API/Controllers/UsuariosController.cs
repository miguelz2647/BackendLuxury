using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Business.Dtos;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/usuario")]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuariosController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    // GET: api/usuario/todos
    [HttpGet("todos")]
    public async Task<IActionResult> GetAll()
    {
        var usuarios = await _usuarioService.GetAllAsync();
        return Ok(usuarios);
    }

    // GET: api/usuario/obtener
    [HttpPost("obtener")]
    public async Task<IActionResult> GetById([FromBody] BuscarDto dto)
    {
        var usuario = await _usuarioService.GetByIdAsync(dto.Id);
        if (usuario == null) return NotFound();
        return Ok(usuario);
    }

    // POST: api/usuario/crear
    [HttpPost("crear")]
    public async Task<IActionResult> Create([FromBody] ZUsuario usuario)
    {
        var created = await _usuarioService.AddAsync(usuario);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    // PUT: api/usuario/actualizar
    [HttpPut("actualizar")]
    public async Task<IActionResult> Update([FromBody] ZUsuario usuario)
    {
        var updated = await _usuarioService.UpdateAsync(usuario);
        if (updated == null) return NotFound();

        return Ok(updated);
    }

    // DELETE: api/usuario/eliminar
    [HttpDelete("eliminar")]
    public async Task<IActionResult> Delete([FromBody] BuscarDto dto)
    {
        var deleted = await _usuarioService.DeleteAsync(dto.Id);
        if (!deleted) return NotFound();

        return NoContent();
    }
}