using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class EmotionCard
    {
        private int emotionCardId;
        private string title;
        private string imageUrl;
        private int coachingId; //this is the id used to find where to send the user after selecting a emotion

        public int EmotionCardId { get => emotionCardId; set => emotionCardId = value; }
        public string Title { get => title; set => title = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public int CoachingId { get => coachingId; set => coachingId = value; }
    }
}
