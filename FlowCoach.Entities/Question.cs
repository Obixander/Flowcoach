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
        private bool isSaveAble;
        private string? answer;

        public int QuestionId { get => questionId; set => questionId = value; }
        public string QuestionText { get => questionText; set => questionText = value; }
        public bool IsSaveAble { get => isSaveAble; set => isSaveAble = value; }
        public string Answer { get => answer; set => answer = value; }

        public QuestionType QuestionType { get => questionType; set => questionType = value; }
    }

    public enum QuestionType
    {
        Current,
        Wanted,
        Barrier,
        Solution,
        FutureProof,
        SelfCare
    }
}
