
using FlowCoach.DataAccess.Interfaces;
using FlowCoach.DataAccess.Repositories;
using FlowCoach.Entities;

namespace FlowCoach.Api
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
            builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IGenericRepository<BodyFlowArticle>, GenericRepository<BodyFlowArticle>>();
            builder.Services.AddScoped<IGenericRepository<BodyFlowCard>, GenericRepository<BodyFlowCard>>();
            builder.Services.AddScoped<IGenericRepository<Card>, GenericRepository<Card>>();
            builder.Services.AddScoped<IGenericRepository<Coaching>, GenericRepository<Coaching>>();
            builder.Services.AddScoped<IGenericRepository<EmotionCard>, GenericRepository<EmotionCard>>();
            builder.Services.AddScoped<IGenericRepository<FlowCoachCard>, GenericRepository<FlowCoachCard>>();
            builder.Services.AddScoped<IGenericRepository<JournalEntry>, GenericRepository<JournalEntry>>();
            builder.Services.AddScoped<IGenericRepository<SelfCareArticle>, GenericRepository<SelfCareArticle>>();
            builder.Services.AddScoped<IGenericRepository<SelfCareCard>, GenericRepository<SelfCareCard>>();

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
