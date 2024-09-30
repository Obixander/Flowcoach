using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Entities
{
    public class Question
    {
        private int questionId;
        private string questionText;
        private QuestionType questionType;

        public int QuestionId { get => questionId; set => questionId = value; }
        public string QuestionText { get => questionText; set => questionText = value; }
    }

    enum QuestionType
    {
        Current,
        Wanted,
        Barrier,
        Solution,
        FutureProof,
        SelfCare
    }
}
