using Microsoft.Extensions.DependencyInjection;
using pedido.apps.Services.Usuarios;

namespace pedido.infra
{
    public static class DependencyInjectionApps
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
