using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class SelfCareHub : Hub
    {
        public async Task<List<SelfCareCard>> GetSelfCareCardsAsync()
        {
            List<SelfCareCard> result = new List<SelfCareCard>();


            result.Add(new SelfCareCard
            {
                CardId = 1,
                Title = "Mindfulness",
                SelfCareArticleId = 1,
                ImageUrl = @"Images/Mindfulness.jfif"
            });
            result.Add(new SelfCareCard
            {
                CardId = 2,
                Title = "Søvn",
                SelfCareArticleId = 2,
                ImageUrl = @"Images/Søvn.jfif"
            });
            result.Add(new SelfCareCard
            {
                CardId = 3,
                Title = "Motion",
                SelfCareArticleId = 3,
                ImageUrl = @"Images/Motion.jfif"
            });
            result.Add(new SelfCareCard
            {
                CardId = 4,
                Title = "Kost",
                SelfCareArticleId = 4,
                ImageUrl = @"Images/Kost.jfif"

            });
            return result;
        }
    }
}
