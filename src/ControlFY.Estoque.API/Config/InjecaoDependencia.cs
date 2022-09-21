using ControlFY.Estoque.Persistencia.Contexto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System;

namespace ControlFY.Estoque.API.Config
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextoEstoque>(options =>
                     options.UseNpgsql(configuration.GetConnectionString("stringConexaoEstoque")));

            //AutoMapper and Mediator
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
