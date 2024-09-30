
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
        public DbSet<SelfcareArticle> SelfcareArticles { get; set; } = null;
        public DbSet<SelfCareCard> SelfcareCards { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmotionCard>()
                .Property(c => c.CardId)
                .HasColumnName("EmotionCardId");
            modelBuilder.Entity<EmotionCard>().HasKey(c => c.CardId);

            modelBuilder.Entity<BodyFlowCard>()
                .Property(c => c.CardId)
                .HasColumnName("BodyFlowCardId");
            modelBuilder.Entity<BodyFlowCard>().HasKey(c => c.CardId);

            modelBuilder.Entity<SelfCareCard>()
                .Property(c => c.CardId)
                .HasColumnName("SelfCareCardId");
            modelBuilder.Entity<SelfCareCard>().HasKey(c => c.CardId);

        }


    }
}
