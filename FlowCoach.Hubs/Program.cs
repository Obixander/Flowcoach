
using FlowCoach.Hubs.Hubs;

namespace FlowCoach.Hubs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSignalR();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowBlazorClient", builder =>
                {
                    builder.WithOrigins("https://localhost:7239/") // Replace with Blazor app URL
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowCredentials();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("AllowBlazorClient");
            app.MapControllers();
            app.MapHub<CoachingHub>("/coachinghub");
            app.MapHub<EmotionHub>("/emotionhub");
            app.MapHub<FlowcoachHub>("/flowcoachhub");
            app.MapHub<BodyflowHub>("/bodyflowhub");
            app.MapHub<BodyflowArticleHub>("/bodyflowarticlehub");
            app.MapHub<SelfCareHub>("/selfcarehub");
            app.MapHub<SelfCarePageHub>("/selfcarepagehub");
            app.Run();
        }
    }
}
