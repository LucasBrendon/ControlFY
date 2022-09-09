using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Persistencia.Repositorio;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Catalogo.Persistencia
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependenciasPersistencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();

            return services;
        }
    }
}
