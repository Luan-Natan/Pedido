using Microsoft.AspNetCore.Mvc;
using pedido.domain.Interfaces.Services;

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
}
