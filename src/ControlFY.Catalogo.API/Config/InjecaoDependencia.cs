using ControlFY.Catalogo.Persistencia.Contexto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace ControlFY.Catalogo.API.Config
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextoCatalogo>(options =>
                     options.UseNpgsql(configuration.GetConnectionString("stringConexaoCatalogo")));

            //AutoMapper and Mediator
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
