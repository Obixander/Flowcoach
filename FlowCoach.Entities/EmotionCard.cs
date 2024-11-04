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

        public int CoachingId
        {
            get => coachingId;
            set
            {
                if (value >= 0)
                {
                    if (value != coachingId)
                        coachingId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }

        }
    }
}
