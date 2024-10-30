using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class FlowcoachHub : Hub
    {
        public async Task<List<FlowCoachCard>> GetFlowCoachCards()
        {
            List<FlowCoachCard> flowCoachCards = new List<FlowCoachCard>(); //this list will be used to contain the infomation from the db later
            flowCoachCards.Add(new FlowCoachCard
            {
                CardId = 1,
                Title = "Forandring",
                Path = "/emotionPanel",
                Description = "Udforsk om dine følelser",
                ImageUrl = @"Images/Forandring.jfif"
            });
            flowCoachCards.Add(new FlowCoachCard
            {
                CardId = 2,
                Title = "Selvomsår",
                Path = "/selfcare",
                Description = "Lær om hvordan du kan hjælpe dig selv",
                ImageUrl = @"Images/Selfcare.jfif"
            });
            flowCoachCards.Add(new FlowCoachCard
            {
                CardId = 3,
                Title = "Showcase",
                Path = "/Showcase",
                Description = "This is the description of the showcase Panel",
                ImageUrl = @"Images/Angst.jfif"
            });
            return flowCoachCards;
        }
    }
}
