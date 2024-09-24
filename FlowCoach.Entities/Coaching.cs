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
        private string content;
        private List<Question> questions;

        public int CoachingId { get => coachingId; set => coachingId = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public List<Question> Questions { get => questions; set => questions = value; }
    }
}
