using FlowCoach.Entities;
using FlowCoach.Hubs.Hubs;
using FlowCoach.Services;
using FlowCoach.Services.Interfaces;

namespace FlowCoach.Hubs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSignalR(options => { options.EnableDetailedErrors = true; });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IApiBase<FlowCoachCard>, ApiBase<FlowCoachCard>> ();
            builder.Services.AddScoped<IApiBase<BodyFlowArticle>, ApiBase<BodyFlowArticle>>();
            builder.Services.AddScoped<IApiBase<BodyFlowCard>, ApiBase<BodyFlowCard>>();
            builder.Services.AddScoped<IApiBase<Coaching>, ApiBase<Coaching>>();
            builder.Services.AddScoped<IApiBase<EmotionCard>, ApiBase<EmotionCard>>();
            builder.Services.AddScoped<IApiBase<FlowCoachCard>, ApiBase<FlowCoachCard>>();
            builder.Services.AddScoped<IApiBase<JournalEntry>, ApiBase<JournalEntry>>();
            builder.Services.AddScoped<IApiBase<Question>, ApiBase<Question>>();
            builder.Services.AddScoped<IApiBase<SelfCareArticle>, ApiBase<SelfCareArticle>>();
            builder.Services.AddScoped<IApiBase<SelfCareCard>, ApiBase<SelfCareCard>>();
            builder.Services.AddScoped<IApiBase<User>, ApiBase<User>>();

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
            app.MapHub<FlowcoachHub>("/flowcoachhub");
            app.Run();
        }
    }
}
