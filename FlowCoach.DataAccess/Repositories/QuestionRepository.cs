using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Repositories
{
    public class QuestionRepository(DataContext context) : GenericRepository<Question>(context),IQuestionRepository
    {
        public async Task<IEnumerable<Question>> GetAllQuestionsByType(QuestionType questionType)
        {
            try
            {
                return await context.Questions.Where(q => q.QuestionType == questionType).AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Question>> GetFirstFiveQuestions(QuestionType questionType)
        {
            try
            {
                return await context.Questions.Where(q => q.QuestionType == questionType).AsNoTracking().Take(5).ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Question>> GetNextFiveQuestions(int lastQuestionId, QuestionType questionType)
        {
            try
            {
                return await context.Set<Question>()
                    .AsNoTracking()
                    .Where(q => q.QuestionId > lastQuestionId && q.QuestionType == questionType)
                    .OrderBy(q => q.QuestionId)  // Assuming you want to order by Id or change to appropriate column
                    .Take(5)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;  // Rethrow without losing the stack trace
            }
        }
    }
}
