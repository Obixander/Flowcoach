using FlowCoach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        Task<IEnumerable<Question>> GetFirstFiveQuestions(QuestionType questionType);
        Task<IEnumerable<Question>> GetNextFiveQuestions(int lastQuestionId, QuestionType questionType);
        Task<IEnumerable<Question>> GetAllQuestionsByType(QuestionType questionType);
        
    }
}
