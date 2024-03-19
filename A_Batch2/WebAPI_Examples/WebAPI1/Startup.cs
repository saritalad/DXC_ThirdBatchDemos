using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI1", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI1 v1"));
            }
            // ref stores address of variable
            // delegate stores address of function()or Method()
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\nThis is the  First Middleware request comp in http  req pipeline\n");
            //    next();
            //    await context.Response.WriteAsync("\n<b>This is the First Middleware comp response in http....</b>\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\nThis is the  Second Middleware Request comp in http  req pipeline");
            //    next();
            //    await context.Response.WriteAsync("\nThis is the Second Middleware comp response in http....\n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("\nThis is the Terminal middleware component");
            //});
        }
    }
}
