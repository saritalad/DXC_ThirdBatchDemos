using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RazorConfigDemo
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

            services.AddRazorPages();
        }
        // httpRequestPipeline Middleware components 
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseRouting();
            //custom Middleware class invoked by system 
            //  app.UseSample();
            //  app.UseAuthorization();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\n<h1> Request 1 handler ");

            //    await next();
            //    await context.Response.WriteAsync("\n<h1> Response 1 handler</h1> ");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\n<h1> Request 2 handler</h1> ");

            //    await next();
            //    await context.Response.WriteAsync("\n<h1> Response 2 handler</h1> \n");
            //});
            //// terminaring midleware component  Run
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("\n <h1> Company name :</h1>" + Configuration["company"]);
               
            //    await context.Response.WriteAsync("\n <h1>Conection String Url:</h1>" + Configuration["ConnectionStrings:connect"]);
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
