using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class SelfCarePageHub : Hub
    {
        public async Task<SelfCareArticle> GetArticleAsync(int articleId)
        {
            SelfCareArticle article = new SelfCareArticle();
            article.SelfcareArticleId = articleId;
            article.Title = "Mindfulness";
            article.Content = "Mindfulness er en måde at være tilstede i nuet på. Det handler om at være opmærksom på det, der sker lige nu og her, uden at dømme det. Det kan være en måde at håndtere stress, angst og depression på. Mindfulness kan også hjælpe dig med at blive mere bevidst om, hvad der sker i dit liv, og hvad du har brug for.";
            article.SoundfileUrl = @"Sounds/Mindfulness.mp3";
            return article;
        }
    }
}
