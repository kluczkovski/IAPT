using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using IAPT.EK.API.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
using IAPT.EK.API.Extensions;

namespace IAPT.EK.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IWebHostEnvironment hostingEnvironment)
        {
            // Working with more than one environment.
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();
            
            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.WebApiConfig();

            services.AddCors();

            // Auto Mapper Setup
            services.AddAutoMapper(typeof(Startup));

            // Identity Setup
            services.AddIdentityConfiguration(Configuration);

            // Setup App Context - System Tables
            services.AppContextConfiguration(Configuration);

            // Swagger Setup
            services.AddSwaggerConfig();

            // Dependency Injection Setup
            services.DIConfiguration();

            // Heath Check
            //services.AddHealthChecks()
            //        .AddCheck("Cities", new MySqlHealthCheck(Configuration.GetConnectionString("DefaultConnection")))
            //        .AddMySql(Configuration.GetConnectionString("DefaultConnection"), name:"MySql");

            //services.AddHealthChecksUI();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(options =>
                {
                    options.AllowAnyOrigin();
                    options.AllowAnyHeader();
                    options.AllowAnyMethod();
                });
            }
            else
            {
                app.UseHsts();
            }


            app.UseSwaggerConfig(provider);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseHealthChecks("/hc", new HealthCheckOptions()
            //{
            //    Predicate = _ => true,
            //    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            //}); 

            //app.UseHealthChecksUI(options =>
            //{
            //    options.UIPath = "/hc-ui";
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
