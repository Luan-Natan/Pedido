using Microsoft.Extensions.DependencyInjection;
using pedido.app.Services.Usuarios;

namespace pedido.infra
{
    public static class DependencyInjectionApp
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
