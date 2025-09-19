using pedido.app.DTOs;
using pedido.domain.Interfaces.Repositories;
using pedido.domain.Models;

namespace pedido.app.Services.Usuarios
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

        public async Task<List<Usuario>> ListarPorIdAsync(string id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task<Usuario> AdicionarAsync(UsuarioDTO usuarioDTO)
        {
            var usuarioNovo = new Usuario(usuarioDTO.Nome, usuarioDTO.Email);

            return await _usuarioRepository.AddAsync(usuarioNovo);
        }

        public async Task<Usuario> AtualizarAsync(string id, UsuarioDTO usuarioDTO)
        {
            var usuarioNovo = new Usuario(id, usuarioDTO.Nome, usuarioDTO.Email);

            return await _usuarioRepository.UpdateAsync(id, usuarioNovo);
        }

        public async Task DeletarPorIdAsync(string id)
        {
            await _usuarioRepository.DeleteByIdAsync(id);
            return;
        }
    }
}
