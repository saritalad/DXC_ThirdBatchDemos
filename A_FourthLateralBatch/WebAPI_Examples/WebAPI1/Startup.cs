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
using System.Runtime.InteropServices;
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
        // Http Request Pipeline 
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IEmpService,EmpService>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI1", Version = "v1" });
            });
        }
        // Http Request Pipeline 
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseSwagger();
            //    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI1 v1"));
            //}

            app.UseRouting();

            app.UseAuthorization();
            // conventional Routing 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            // HttpContext request object 
            // delegate is nothing but function pointer 
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" This is First  Middleware Request in the pipeline\n");
            //    await next();
            //    await context.Response.WriteAsync("\n This is First  Middleware Response ");

            //});
            //// next desk
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" This is Second  Middleware Request in the pipeline\n");
            //    await next();
            //    await context.Response.WriteAsync("\n This is Second  Middleware Response ");

            //});
            // desk boarding pass is issued
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("\n This is the Terminal Middleware Component ");
            //});

            //app.Map("/route1", HandleMapTest1);

            //app.Map("/route2", HandleMapTest2);

            //static void HandleMapTest1(IApplicationBuilder app)
            //{
            //    app.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("Map Test 1");

            //    });
            //}

            //static void HandleMapTest2(IApplicationBuilder app)
            //{
            //    app.Run(async context =>
            //    {
            //        await context.Response.WriteAsync("Map Test 2");
            //    });
            //}


        }
    }
}
