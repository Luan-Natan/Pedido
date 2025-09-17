using pedido.domain.Interfaces.Repositories;
using pedido.domain.Interfaces.Services;
using pedido.domain.Models;

namespace pedido.app.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<Usuario>> ListarTudoAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }
    }
}