using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class BodyflowArticleHub : Hub
    {
        public async Task<BodyFlowArticle> GetArticleBy(int id)
        {
            BodyFlowArticle testing = new BodyFlowArticle();
            testing.BodyFlowArticleId = 1;
            testing.Title = "Sanser";
            testing.Content = new();
            testing.Content.Add("Sight opens a vast world of color, shape, and movement. Through it, we see beauty in art, nature, and people, observing the intricate details that make each moment unique. Sight transforms our surroundings into a vibrant canvas, guiding us through spaces, scenes, and stories.");
            testing.Content.Add("Sound surrounds us with a symphony of voices, rhythms, and melodies. From the subtle rustling of leaves to the intensity of a storm, sound evokes emotion and enriches experiences. It bridges communication and connects us to the harmonies of life.");
            testing.Content.Add("Touch grounds us in the physical world, letting us feel textures, temperatures, and forms. From the warmth of a loved one’s hand to the roughness of natural materials, touch enhances our interactions, offering a deeper connection to people and places.");
            testing.Content.Add("Taste brings the world’s flavors to life, transforming meals into memories. Sweet, salty, sour, and savory experiences carry cultural and personal meaning, creating a sensory journey that satisfies and delights.");
            testing.Content.Add("Smell can transport us instantly, evoking memories and emotions tied to specific scents. Whether it’s the freshness of rain, the richness of a favorite dish, or the perfume of a familiar place, smell connects us deeply to moments, people, and emotions.");
            testing.Images = new();
            testing.Images.Add("Images/Sanser.jfif");
            testing.Images.Add("Images/Angst.jfif");
            return testing;
        }
    }
}
