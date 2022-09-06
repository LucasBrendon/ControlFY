using ControlFY.Catalogo.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlFY.Catalogo.API.Config
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextoCatalogo>(options =>
                     options.UseNpgsql(configuration.GetConnectionString("stringConexaoCatalogo")));

            return services;
        }
    }
}
