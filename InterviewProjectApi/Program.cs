
using InterviewProjectApi.Mappers;
using InterviewProjectApi.Services.Abstract;
using InterviewProjectApi.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace InterviewProjectApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddScoped<IBlogPostService, BlogPostService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(policy =>
            {
                policy.WithOrigins("http://localhost:7069", "https://localhost:7069")
                .AllowAnyMethod()
                .WithHeaders(HeaderNames.ContentType);
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

           

            app.MapControllers();

            app.Run();
        }
    }
}
