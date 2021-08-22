using AutoMapper;
using catalogo.Controllers.V1;
using catalogo.Entity;
using catalogo.InputModel;
using catalogo.Interface;
using catalogo.Repository;
using catalogo.Repository.Data;
using catalogo.Service;
using catalogo.ViewModel;
using ExemploApiCatalogoJogos.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "Cat�logo de Jogos", 
                    Version = "v1",
                    Description = "Desafio Avanade CodeAnywhere",
                    Contact = new OpenApiContact
                    {
                        Name = "Elayne Nat�lia de Oliveira Argollo",
                        Email = string.Empty,
                        Url = new Uri("https://github.com/elayneargollo"),
                    }
                });
            });

            services.AddScoped<IJogoService, JogoService>();
            services.AddScoped<IJogoRepository, JogoRepository>();

            string stringConnection = "Server=127.0.0.1;DataBase=bootCamp;Uid=root;Pwd=admin1234";
            services.AddDbContext<JogoContext>((options) => options.UseMySql(stringConnection));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Jogo, JogoViewModel>();
                cfg.CreateMap<JogoInputModel, Jogo>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "catalogo v1"));
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
