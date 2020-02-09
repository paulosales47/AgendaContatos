using AgendaContatos.Domain.Core;
using AgendaContatos.Domain.Interfaces.Repositories;
using AgendaContatos.Infra.Repositories;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace AgendaContatos.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiVersioning();

            services.AddControllers();

            services.AddDbContext<AgendaContatoContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("ConnectionMySql"))
            );

            ConfigurarIoc(services);

            ConfigurarMediatR(services);

            ConfigurarSwagger(services);

            ConfigureCors(services);
        }

        private void ConfigurarIoc(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }

        private static void ConfigurarMediatR(IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("AgendaContatos.Domain");

            AssemblyScanner
                .FindValidatorsInAssembly(assembly)
                .ForEach(result => services.AddScoped(result.InterfaceType, result.ValidatorType));

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(FailFastRequestBehavior<,>));

            services.AddMediatR(assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "v1.0");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ConfigurarSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1.0", new OpenApiInfo
                {
                    Title = "API - Agenda Contatos",
                    Version = "1.0",
                    Description = "API Utilizada para estudo de Mediatr e FluentValidation",
                    TermsOfService = new Uri("https://github.com/paulosales47"),
                    Contact = new OpenApiContact
                    {
                        Name = "Paulo Sampaio",
                        Email = "paulohenrique.sales47@gmail.com",
                        Url = new Uri("https://github.com/paulosales47")
                    }
                })
            );
        }

        private void ConfigureCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("origin", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                    builder.AllowCredentials();
                });
            });
        }
    }
}
