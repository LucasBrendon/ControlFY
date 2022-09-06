using ControlFY.Estoque.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Estoque.API.Config
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextoEstoque>(options =>
                     options.UseNpgsql(configuration.GetConnectionString("stringConexaoEstoque")));

            return services;
        }
    }
}
