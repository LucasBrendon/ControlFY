using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Estoque.Aplicacao
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependenciasAplicacao(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
