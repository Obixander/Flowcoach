using FlowCoach.Entities;

namespace FlowCoach.Common
{
    public interface IFlowCoachHub
    {
        Task<List<FlowCoachCard>> GetFlowCoachCards(); //async
        Task<SelfCareArticle> GetArticleAsync(int articleId); //async
        Task<List<SelfCareCard>> GetSelfCareCardsAsync(); //async
        Task<List<EmotionCard>> GetEmotionCardsAsync(); //async
        Task<Coaching> GetCoachingAsyncBy(int id); //async
        Task<List<BodyFlowCard>> GetBodyflowCards(); //async
        Task<BodyFlowArticle> GetArticleBy(int id); //async
    }
}
