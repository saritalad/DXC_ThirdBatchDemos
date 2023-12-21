using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace RazorConfigDemo
{
    public class SampleMiddleware
    {
        public RequestDelegate _next;
        public SampleMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        public async  Task InvokeAsync(HttpContext context) {

            await context.Response.WriteAsync("\n <h1> this is request from Sample Middleware </h1>");
            await _next.Invoke(context);
            await context.Response.WriteAsync("\n <h1> this is response from Sample Middleware </h1>");

        }
      
    }

    public static class MiddlewareExtensions
    {

        public static IApplicationBuilder UseSample(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SampleMiddleware>();
        }
   }



}
