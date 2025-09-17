using pedido.domain.Models;

namespace pedido.domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> ListarTudoAsync();
    }
}