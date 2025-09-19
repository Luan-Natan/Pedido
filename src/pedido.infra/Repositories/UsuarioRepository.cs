using pedido.domain.Interfaces.Repositories;
using pedido.domain.Models;
using pedido.infra.Context;

namespace pedido.infra.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly PedidoContext _pedidoContext;

        public UsuarioRepository(PedidoContext pedidoContext) : base(pedidoContext.UsuariosCollection)
        {
            _pedidoContext = pedidoContext;
        }
    }
}
