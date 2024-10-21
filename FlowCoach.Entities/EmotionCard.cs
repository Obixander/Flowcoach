using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class EmotionCard : Card
    {
        private int coachingId; //this is the id used to find where to send the user after selecting a emotion
        private Coaching coaching;

        public EmotionCard(Coaching coaching)
        {
            Coaching = coaching;
        }

        public int CoachingId { get => coachingId; set => coachingId = value; }
        public Coaching Coaching { get => coaching; set => coaching = value; }
    }
}
