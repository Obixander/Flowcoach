using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class EmotionHub : Hub
    {
        public async Task<List<EmotionCard>> GetEmotionCardsAsync()
        {
            List<EmotionCard> emotionCards = new();
            emotionCards.Add(new EmotionCard
            {
                CardId = 1,
                CoachingId = 1,
                Title = "Stressed",
                ImageUrl = @"Images/Stressed.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 2,
                CoachingId = 2,
                Title = "Angst",
                ImageUrl = @"Images/Angst.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 3,
                CoachingId = 3,
                Title = "Deprimeret",
                ImageUrl = @"Images/Deprimeret.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 4,
                CoachingId = 4,
                Title = "Ikke god nok",
                ImageUrl = @"Images/IkkeGodNok.jpeg"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 5,
                CoachingId = 5,
                Title = "Vred",
                ImageUrl = @"Images/Vred.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 6,
                CoachingId = 6,
                Title = "Afhængig af SoMe",
                ImageUrl = @"Images/SoMe.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 7,
                CoachingId = 7,
                Title = "Stressed",
                ImageUrl = @"Images/Stressed.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 8,
                CoachingId = 8,
                Title = "Angst",
                ImageUrl = @"Images/Angst.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 9,
                CoachingId = 9,
                Title = "Deprimeret",
                ImageUrl = @"Images/Deprimeret.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 10,
                CoachingId = 10,
                Title = "Ikke god nok",
                ImageUrl = @"Images/IkkeGodNok.jpeg"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 11,
                CoachingId = 11,
                Title = "Vred",
                ImageUrl = @"Images/Vred.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 12,
                CoachingId = 12,
                Title = "Afhængig af SoMe",
                ImageUrl = @"Images/SoMe.jfif"
            });
            return emotionCards;
        }
    
    }
} 
