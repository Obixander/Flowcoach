using FlowCoach.Common;
using FlowCoach.Entities;
using FlowCoach.Services;
using FlowCoach.Services.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class FlowcoachHub
        (
        IApiBase<BodyFlowArticle> bodyFlowArticleService,
        IApiBase<BodyFlowCard> bodyFlowCardService,
        IApiBase<Coaching> coachingService,
        IApiBase<EmotionCard> emotionCardService,
        IApiBase<JournalEntry> journalEntryService,
        IApiBase<Question> questionService,
        IApiBase<SelfCareArticle> selfCareArticleService,
        IApiBase<SelfCareCard> selfCareCardService,
        IApiBase<User> userService,
        IFlowcoachCardService flowCoachCardService
        ) : Hub, IFlowCoachHub
    {
        public async Task<List<FlowCoachCard>> GetFlowCoachCards()
        {
            return (List<FlowCoachCard>)await flowCoachCardService.GetAll();
        }

        public async Task<SelfCareArticle> GetArticleAsync(int articleId)
        {
          return await selfCareArticleService.GetBy(articleId);
        }

        public async Task<List<SelfCareCard>> GetSelfCareCardsAsync()
        {
         return (List<SelfCareCard>)await selfCareCardService.GetAll();
        }

        public async Task<List<EmotionCard>> GetEmotionCardsAsync()
        {
          return (List<EmotionCard>)await emotionCardService.GetAll();
        }

        public async Task<Coaching> GetCoachingAsyncBy(int id)
        {
           return await coachingService.GetBy(id);
        }

        public async Task<List<BodyFlowCard>> GetBodyflowCards()
        {
          return (List<BodyFlowCard>)await bodyFlowCardService.GetAll();
        }

        public async Task<BodyFlowArticle> GetArticleBy(int id)
        {
            return await bodyFlowArticleService.GetBy(id);
        }
    }
}
