
using FlowCoach.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowCoach.DataAccess
{
    public class FlowCoachContext : DbContext
    {
        public FlowCoachContext(DbContextOptions<FlowCoachContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; } = null;
        public DbSet<Coaching> Coachings { get; set; } = null;
        public DbSet<JournalEntry> JournalEntries { get; set; } = null;
        public DbSet<Question> Questions { get; set; } = null;
        public DbSet<EmotionCard> EmotionCards { get; set; } = null;
        public DbSet<BodyFlowCard> BodyFlowCards { get; set; } = null;
        public DbSet<BodyFlowArticle> BodyFlowArticles { get; set; } = null;

       

    }
}
