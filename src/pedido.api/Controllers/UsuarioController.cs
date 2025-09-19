using Microsoft.AspNetCore.Mvc;
using pedido.app.DTOs;
using pedido.app.Services.Usuarios;

namespace pedido.api.Controllers;

[ApiController]
[Route("usuarios")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet()]
    public async Task<IActionResult> ObterListaUsuario()
    {
        return Ok(await _usuarioService.ListarTudoAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterUsuarioPorId([FromRoute] string id)
    {
        return Ok(await _usuarioService.ListarPorIdAsync(id));
    }

    [HttpPost()]
    public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDTO usuarioDTO)
    {
        return Ok(await _usuarioService.AdicionarAsync(usuarioDTO));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarUsuario([FromRoute] string id, [FromBody] UsuarioDTO usuarioDTO)
    {
        return Ok(await _usuarioService.AtualizarAsync(id, usuarioDTO));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarUsuarioPorId([FromRoute] string id)
    {
        await _usuarioService.DeletarPorIdAsync(id);
        return Ok();
    }
}
