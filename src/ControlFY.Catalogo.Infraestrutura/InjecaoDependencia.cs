using ControlFY.Catalogo.Infraestrutura.RabbitMq.ProdutoSender;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Catalogo.Infraestrutura
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependenciasInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoSender, ProdutoSender>();

            return services;
        }
    }
}
