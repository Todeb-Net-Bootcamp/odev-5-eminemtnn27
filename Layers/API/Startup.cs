using Business.Abstract;
using Business.Concrete;
using Business.Configuration.Mapper;
using Business.Configuration.Validator.FluentValidation;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Ef;
using DataAccessLayer.DbContexts;
using DTO.Reader;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //DI,Singleton,Scope,transit
            //Docker da kulland���m�z 3 yakla��m 

            //IReaderRepoistory,DapperReaderRepository,efReaderrepository
            //readerservice,adeneme,�readerservice

            //addSingleton =bir tane static class olu�tur.Uygulama aya�a kalkt���nda bir kez new lenir.Ayn� instance �zerinden i�lemleri ger�ekle�tirir
            //addScope=Scope un �mr� requestin gelip response dan ��k�ncaya kadar ge�erli s�rede.Her bir requestte yeniden �al���r yeni de�er olu�turur
            //addTransient=metot bazl� �al���r.Her nerde istek yaparsan yap,sunucu i�erisinde her istekte yeniden y�klenir(new lenir)

            services.AddDbContext<BookContext>(ServiceLifetime.Transient);

            services.AddAutoMapper(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            //services.AddScoped<IValidator<CreateReaderRequest>, CreateReaderRequestValidator>();
            //DbContext her �a�r�ld���nda sistem taraf�ndan new lenir
            services.AddScoped<IReaderService, ReaderService>(); 
            services.AddScoped<IReaderRepository, EfReaderRepository>();
            //her requestte yeniden y�klensin
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
