using FlowCoach.Common;
using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class FlowcoachHub : Hub, IFlowCoachHub
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
                Path = "/selfcarePanel",
                Description = "Lær om hvordan du kan hjælpe dig selv",
                ImageUrl = @"Images/Selfcare.jfif"
            });
            return flowCoachCards;
        }

        public async Task<SelfCareArticle> GetArticleAsync(int articleId)
        {
            SelfCareArticle article = new SelfCareArticle();
            article.SelfcareArticleId = articleId;
            article.Title = "Mindfulness";
            article.Content = "Mindfulness er en måde at være tilstede i nuet på. Det handler om at være opmærksom på det, der sker lige nu og her, uden at dømme det. Det kan være en måde at håndtere stress, angst og depression på. Mindfulness kan også hjælpe dig med at blive mere bevidst om, hvad der sker i dit liv, og hvad du har brug for.";
            article.SoundfileUrl = @"Sounds/Mindfulness.mp3";
            return article;
        }

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

        public async Task<List<EmotionCard>> GetEmotionCardsAsync()
        {
            List<EmotionCard> emotionCards = new();
            emotionCards.Add(new EmotionCard
            {
                CardId = 1,
                CoachingId = 1,
                Title = "Stressed",
                ImageUrl = @"Images/Stressed.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 2,
                CoachingId = 2,
                Title = "Angst",
                ImageUrl = @"Images/Angst.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 3,
                CoachingId = 3,
                Title = "Deprimeret",
                ImageUrl = @"Images/Deprimeret.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 4,
                CoachingId = 4,
                Title = "Ikke god nok",
                ImageUrl = @"Images/IkkeGodNok.jpeg"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 5,
                CoachingId = 5,
                Title = "Vred",
                ImageUrl = @"Images/Vred.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 6,
                CoachingId = 6,
                Title = "Afhængig af SoMe",
                ImageUrl = @"Images/SoMe.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 7,
                CoachingId = 7,
                Title = "Stressed",
                ImageUrl = @"Images/Stressed.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 8,
                CoachingId = 8,
                Title = "Angst",
                ImageUrl = @"Images/Angst.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 9,
                CoachingId = 9,
                Title = "Deprimeret",
                ImageUrl = @"Images/Deprimeret.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 10,
                CoachingId = 10,
                Title = "Ikke god nok",
                ImageUrl = @"Images/IkkeGodNok.jpeg"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 11,
                CoachingId = 11,
                Title = "Vred",
                ImageUrl = @"Images/Vred.jfif"
            });
            emotionCards.Add(new EmotionCard
            {
                CardId = 12,
                CoachingId = 12,
                Title = "Afhængig af SoMe",
                ImageUrl = @"Images/SoMe.jfif"
            });
            return emotionCards;
        }
        
        public async Task<Coaching> GetCoachingAsyncBy(int id)
        {
            //change later to call the api using gRPC
            if (id == 1)
            {
                Coaching testing = new Coaching
                {
                    CoachingId = 1,
                    Title = "Stressed",
                    Content = new List<string>
                {
                    "Stress is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Stress is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Stress is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Stress is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Stress is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives."
                },
                    IntroText = new List<string>
                {
                    "This is the intro text of the stressed coaching question",
                    "This is the second intro text of the stressed coaching question",
                    "This is the third intro text of the stressed coaching question",
                    "This is the fourth intro text of the stressed coaching question",
                    "This is the fifth intro text of the stressed coaching question"
                },
                };
                #region test
                testing.Questions = new();
                testing.Questions.Add(new Question { QuestionId = 1, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 2, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 3, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 4, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 5, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 6, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });

                testing.Questions.Add(new Question { QuestionId = 7, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 8, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 9, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 10, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 11, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 12, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 13, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });

                testing.Questions.Add(new Question { QuestionId = 14, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)2 });
                testing.Questions.Add(new Question { QuestionId = 15, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)2 });
                testing.Questions.Add(new Question { QuestionId = 16, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)2 });

                testing.Questions.Add(new Question { QuestionId = 17, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)3 });
                testing.Questions.Add(new Question { QuestionId = 18, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)3 });
                testing.Questions.Add(new Question { QuestionId = 19, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)3 });

                testing.Questions.Add(new Question { QuestionId = 20, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)4 });
                testing.Questions.Add(new Question { QuestionId = 21, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)4 });
                testing.Questions.Add(new Question { QuestionId = 22, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)4 });
                #endregion
                return testing;
            }
            else
            {
                Coaching testing = new Coaching
                {
                    CoachingId = 2,
                    Title = "Angst",
                    Content = new List<string>
                {
                    "Angst is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Angst is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Angst is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Angst is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives.",
                    "Angst is an unavoidable part of life, and it can be experienced in many different ways. While some individuals may handle stress well, others may find themselves struggling to cope with the pressures they face on a daily basis. Stress can have a negative impact on both physical and mental health, causing symptoms such as fatigue, anxiety, depression, headaches, and even heart disease. In order to manage stress effectively, it is important to understand what causes it in the first place, how it affects our bodies and minds, and what steps we can take to reduce its impact on our lives."
                },
                    IntroText = new List<string>
                {
                    "This is the intro text of the Angst coaching question",
                    "This is the second intro text of the Angst coaching question",
                    "This is the third intro text of the Angst coaching question",
                    "This is the fourth intro text of the Angst coaching question",
                    "This is the fifth intro text of the Angst coaching question"
                },
                };
                #region test
                testing.Questions = new();
                testing.Questions.Add(new Question { QuestionId = 1, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 2, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 3, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 4, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 5, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });
                testing.Questions.Add(new Question { QuestionId = 6, QuestionText = "How are you feeling?", QuestionType = (QuestionType)0 });

                testing.Questions.Add(new Question { QuestionId = 7, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 8, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 9, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 10, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 11, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 12, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });
                testing.Questions.Add(new Question { QuestionId = 13, QuestionText = "How are you feeling?", QuestionType = (QuestionType)1 });

                testing.Questions.Add(new Question { QuestionId = 14, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)2 });
                testing.Questions.Add(new Question { QuestionId = 15, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)2 });
                testing.Questions.Add(new Question { QuestionId = 16, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)2 });

                testing.Questions.Add(new Question { QuestionId = 17, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)3 });
                testing.Questions.Add(new Question { QuestionId = 18, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)3 });
                testing.Questions.Add(new Question { QuestionId = 19, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)3 });

                testing.Questions.Add(new Question { QuestionId = 20, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)4 });
                testing.Questions.Add(new Question { QuestionId = 21, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)4 });
                testing.Questions.Add(new Question { QuestionId = 22, QuestionText = "How is fixing this not worky?", QuestionType = (QuestionType)4 });
                #endregion
                return testing;
            }
        }

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
