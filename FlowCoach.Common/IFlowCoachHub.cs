using FlowCoach.Entities;

namespace FlowCoach.Common
{
    public interface IFlowCoachHub
    {
        public Task<List<FlowCoachCard>> GetFlowCoachCards(); //async
        public Task<SelfCareArticle> GetArticleAsync(int articleId); //async
        public Task<List<SelfCareCard>> GetSelfCareCardsAsync(); //async
        public Task<List<EmotionCard>> GetEmotionCardsAsync(); //async
        public Task<Coaching> GetCoachingAsyncBy(int id); //async
        public Task<List<BodyFlowCard>> GetBodyflowCards(); //async
        public Task<BodyFlowArticle> GetArticleBy(int id); //async
    }
}
