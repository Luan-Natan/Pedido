using Microsoft.Extensions.DependencyInjection;
using pedido.domain.Interfaces.Repositories;
using pedido.infra.Context;
using pedido.infra.Repositories;

namespace pedido.infra
{
    public static class DependencyInjectionInfra
    {
        public static IServiceCollection ConfigureContexts(this IServiceCollection services)
        {
            services.AddSingleton<PedidoContext>();

            return services;
        }

        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddSingleton<PedidoContext>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
