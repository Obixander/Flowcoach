using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class Coaching
    {
        private int coachingId;
        private string title;
        private List<string> content;
        private List<Question> questions;
        private List<string> introText;

        public int CoachingId { get => coachingId; set => coachingId = value; }
        public string Title { get => title; set => title = value; }
        public List<Question> Questions { get => questions; set => questions = value; }
        public List<string> Content { get => content; set => content = value; }
        public List<string> IntroText { get => introText; set => introText = value; }

    }
}
