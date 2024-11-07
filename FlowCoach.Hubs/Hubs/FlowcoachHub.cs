using FlowCoach.Common;
using FlowCoach.Entities;
using FlowCoach.Services;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class FlowcoachHub : Hub, IFlowCoachHub
    {
        public async Task<List<FlowCoachCard>> GetFlowCoachCards()
        {
            FlowCoachCardService Service = new();
            return (List<FlowCoachCard>)await Service.GetAll();
        }

        public async Task<SelfCareArticle> GetArticleAsync(int articleId)
        {
            SelfCareArticleService Service = new();
            return await Service.GetBy(articleId);
        }

        public async Task<List<SelfCareCard>> GetSelfCareCardsAsync()
        {
            SelfCareCardService Service = new();
            return (List<SelfCareCard>)await Service.GetAll();
        }

        public async Task<List<EmotionCard>> GetEmotionCardsAsync()
        {
            EmotionCardService Service = new();
            return (List<EmotionCard>)await Service.GetAll();
        }
        
        public async Task<Coaching> GetCoachingAsyncBy(int id)
        {
            CoachingService Service = new();
            return await Service.GetBy(id);
        }

        public async Task<List<BodyFlowCard>> GetBodyflowCards()
        {
            BodyFlowCardService Service = new();
            return (List<BodyFlowCard>)await Service.GetAll();
        }

        public async Task<BodyFlowArticle> GetArticleBy(int id)
        {
            BodyFlowArticleService Service = new();
            return await Service.GetBy(id);
        }
    }
}
