using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Servicos;
using ControlFY.Catalogo.Aplicacao.Comum.Servicos;
using ControlFY.Catalogo.Infraestrutura.RabbitMq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolverDependenciasAplicacao(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoServico, ProdutoServico>();

            return services;
        }
    }
}
