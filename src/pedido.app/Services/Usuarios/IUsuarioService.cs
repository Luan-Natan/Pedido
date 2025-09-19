using pedido.app.DTOs;
using pedido.domain.Models;

namespace pedido.app.Services.Usuarios
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> ListarTudoAsync();

        Task<List<Usuario>> ListarPorIdAsync(string id);

        Task<Usuario> AdicionarAsync(UsuarioDTO usuario);

        Task<Usuario> AtualizarAsync(string id, UsuarioDTO usuarioDTO);

        Task DeletarPorIdAsync(string id);
    }
}
