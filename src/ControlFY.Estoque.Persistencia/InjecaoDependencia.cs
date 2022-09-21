using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Persistencia.Repositorio;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Estoque.Persistencia
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependenciasPersistencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();

            return services;
        }
    }
}
