using FlowCoach.Common;
using FlowCoach.Entities;
using FlowCoach.Services;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class FlowcoachHub() : Hub, IFlowCoachHub
    {
        public async Task<List<FlowCoachCard>> GetFlowCoachCards()
        {
            return (List<FlowCoachCard>)await FlowCoachCardService.GetAll();
        }

        public async Task<SelfCareArticle> GetArticleAsync(int articleId)
        {
            return await SelfcareArticleService.GetBy(articleId);
        }

        public async Task<List<SelfCareCard>> GetSelfCareCardsAsync()
        {
            return (List<SelfCareCard>)await SelfCareCardService.GetAll();
        }

        public async Task<List<EmotionCard>> GetEmotionCardsAsync()
        {
            return (List<EmotionCard>)await EmotionCardService.GetAll();
        }

        public async Task<Coaching> GetCoachingAsyncBy(int id)
        {
            return await CoachingService.GetBy(id);
        }

        public async Task<List<BodyFlowCard>> GetBodyflowCards()
        {
            return (List<BodyFlowCard>)await BodyFlowCardService.GetAll();
        }

        public async Task<BodyFlowArticle> GetArticleBy(int id)
        {
            return await BodyFlowArticleService.GetBy(id);
        }
    }
}
