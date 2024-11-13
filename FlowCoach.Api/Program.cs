
using FlowCoach.DataAccess;
using FlowCoach.DataAccess.Interfaces;
using FlowCoach.DataAccess.Repositories;
using FlowCoach.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;
namespace FlowCoach.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ICoachingRepository, CoachingRepository>();

            builder.Services.AddScoped<IGenericRepository<BodyFlowArticle>, GenericRepository<BodyFlowArticle>>();
            builder.Services.AddScoped<IGenericRepository<BodyFlowCard>, GenericRepository<BodyFlowCard>>();
            builder.Services.AddScoped<IGenericRepository<Card>, GenericRepository<Card>>();
            builder.Services.AddScoped<IGenericRepository<Coaching>, GenericRepository<Coaching>>();
            builder.Services.AddScoped<IGenericRepository<EmotionCard>, GenericRepository<EmotionCard>>();
            builder.Services.AddScoped<IGenericRepository<FlowCoachCard>, GenericRepository<FlowCoachCard>>();
            builder.Services.AddScoped<IGenericRepository<JournalEntry>, GenericRepository<JournalEntry>>();
            builder.Services.AddScoped<IGenericRepository<SelfCareArticle>, GenericRepository<SelfCareArticle>>();
            builder.Services.AddScoped<IGenericRepository<SelfCareCard>, GenericRepository<SelfCareCard>>();

            builder.Services.AddControllers().AddJsonOptions(x =>
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            builder.Services.AddControllers() //fixes some ef issues somehow?? (cycle depth of 32 or more)
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
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


            app.MapControllers();

            app.Run();
        }
    }
}
