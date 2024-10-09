using FlowCoach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Interfaces
{
    public interface IQuestionRepository
    {
        List<Question> GetFirstFiveQuestions(QuestionType questionType);
        List<Question> GetNextFiveQuestions(int lastQuestionId, QuestionType questionType);
        List<Question> GetAllQuestionsByType(QuestionType questionType);
        
    }
}
