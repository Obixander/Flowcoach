using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private int? coachingId;
        private int? selfCareArticleId;
        private Coaching? coaching;
        private SelfCareArticle? selfCareArticle;

        public int QuestionId
        {
            get => questionId;
            set
            {
                if (value >= 0)
                {
                    if (value != questionId)
                        questionId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }
        }
        public string QuestionText
        {
            get => questionText;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != questionText)
                        questionText = value;
                }
                else
                {
                    throw new Exception("Question text must not be empty");
                }

            }
        }
        public bool IsSaveAble
        {
            get => isSaveAble;
            set
            {
                if (questionType == QuestionType.Current || questionType == QuestionType.Barrier)
                {
                    isSaveAble = false;

                }
                if (value != isSaveAble)
                    isSaveAble = value;
            }
        }
        public string Answer
        {
            get => answer;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) //if the user didnt answer the question sets it to be "" to avoid null reference exceptions
                    answer = "";
                else
                {
                    if (value != answer)
                        answer = value;
                }
            }
        }

        public QuestionType QuestionType 
        {
            get => questionType; 
            set 
            {
                if ((int)value <= 5)
                {
                    if (value != questionType)
                        questionType = value;
                }
                else
                {
                    throw new Exception("The value was greater the max allowed");
                }
            }
        }

        public int? CoachingId { get => coachingId; set => coachingId = value; }
        public int? SelfCareArticleId { get => selfCareArticleId; set => selfCareArticleId = value; }
        public Coaching? Coaching { get => coaching; set => coaching = value; }
        public SelfCareArticle? SelfCareArticle { get => selfCareArticle; set => selfCareArticle = value; }
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
