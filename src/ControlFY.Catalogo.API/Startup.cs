using ControlFY.Catalogo.API.Config;
using ControlFY.Catalogo.API.Filtros;
using ControlFY.Catalogo.Persistencia;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using FluentValidation.AspNetCore;
using ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Criar;
using Newtonsoft.Json;
using ControlFY.Catalogo.Infraestrutura;
using ControlFY.Catalogo.Aplicacao;
using ControlFY.Catalogo.Infraestrutura.RabbitMq.Config;
using System;

namespace ControlFY.Catalogo.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RabbitMqConfiguration>(Configuration.GetSection("RabbitConfig"));

            services.ResolverDependencias(Configuration);
            services.ResolverDependenciasPersistencia(Configuration);
            services.ResolverDependenciasAplicacao(Configuration);
            services.ResolverDependenciasInfraestrutura(Configuration);

            services.AddControllers();

            services.AddHttpContextAccessor();
            services
                .AddMvc(options => options.Filters.Add(typeof(FiltroExcecao)))
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CriarCategoriaValidador>())
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ControlFY.Catalogo.API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ControlFY.Catalogo.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
