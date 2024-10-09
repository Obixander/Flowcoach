using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Repositories
{
    public class QuestionRepository(DataContext context) : GenericRepository<Question>(context),IQuestionRepository
    {
        public List<Question> GetAllQuestionsByType(QuestionType questionType)
        {
            return context.Questions.Where(q => q.QuestionType == questionType).ToList();
        }

        public List<Question> GetFirstFiveQuestions(QuestionType questionType)
        {
        }

        public List<Question> GetNextFiveQuestions(int lastQuestionId, QuestionType questionType)
        {
            throw new NotImplementedException();
        }
    }
}
