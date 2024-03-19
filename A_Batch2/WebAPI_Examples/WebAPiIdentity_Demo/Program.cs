
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using WebAPiIdentity_Demo.Data;

namespace WebAPiIdentity_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            var connectionString = builder.Configuration.GetConnectionString("MyConstr") ?? throw new InvalidOperationException("Connection string 'AppDBContextConnection' not found.");

            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddAuthentication();
            builder.Services.AddAuthentication();
            builder.Services.AddIdentityApiEndpoints<Microsoft.AspNetCore.Identity.IdentityUser>()
             .AddEntityFrameworkStores<DataContext>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            // builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapIdentityApi<IdentityUser>();
           
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
