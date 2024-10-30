using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class CoachingHub : Hub
    {
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
    }
}
