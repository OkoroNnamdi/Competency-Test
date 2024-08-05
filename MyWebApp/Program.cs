using Document_Oriented_Database.Models;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Extensions;
using RelationDataBaseSystem.Infrastructure;

namespace MyWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ProductDbContext>(opt =>
         opt.UseSqlServer((builder.Configuration.GetConnectionString("ConnStr"))));

            // Add services to the container.
            builder.Services.AddHttpClient();

            // Configure AutoMapper
            builder.Services.ConfigureAutoMappers();

            // Register Dependency Injection Service Extension
            builder.Services.AddDependencyInjection();

            //configure swagger
            builder.Services.AddSwagger();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.Configure<DatabaseSetting>(
                    builder.Configuration.GetSection("myDb"));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
