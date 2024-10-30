using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class BodyflowHub : Hub
    {
        public async Task<List<BodyFlowCard>> GetBodyflowCards()
        {
            List<BodyFlowCard> BodyFlowCards = new();
            BodyFlowCards.Add(new BodyFlowCard
            {
                CardId = 1,
                BodyFlowArticleId = 1,
                Title = "Sanser",
                ImageUrl = @"Images/Sanser.jfif"
            });

            BodyFlowCards.Add(new BodyFlowCard
            {
                CardId = 2,
                BodyFlowArticleId = 2,
                Title = "Repræsentations-system",
                ImageUrl = @"Images/Repræsentations-system.png"
            });
            BodyFlowCards.Add(new BodyFlowCard
            {
                CardId = 3,
                BodyFlowArticleId = 3,
                Title = "Tænker",
                ImageUrl = @"Images/Tænker.jfif"
            });
            BodyFlowCards.Add(new BodyFlowCard
            {
                CardId = 4,
                BodyFlowArticleId = 4,
                Title = "Følelser",
                ImageUrl = @"Images/Følelser.jfif"
            });
            BodyFlowCards.Add(new BodyFlowCard
            {
                CardId = 5,
                BodyFlowArticleId = 5,
                Title = "Adfærd",
                ImageUrl = @"Images/Adfærd.jfif"
            });
            BodyFlowCards.Add(new BodyFlowCard
            {
                CardId = 6,
                BodyFlowArticleId = 6,
                Title = "Nervesystemet",
                ImageUrl = @"Images/Nervesystemet.jfif"
            });
            return BodyFlowCards;
        }
    }
}
