using ControlFY.Estoque.Infraestrutura.RabbitMq.ProdutoConsumer;
using ControlFY.Estoque.Infraestrutura.Servicos.Produtos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Estoque.Infraestrutura
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependenciasInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoReceiverServico, ProdutoReceiverServico>();
            services.AddHostedService<ProdutoConsumer>();

            return services;
        }
    }
}
