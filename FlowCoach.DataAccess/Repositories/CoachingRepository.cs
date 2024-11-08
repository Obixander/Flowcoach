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

    public class CoachingRepository(DataContext context) : GenericRepository<Coaching>(context), ICoachingRepository
    {
        public async Task<Coaching> GetByAsync(int id)
        {
            try
            {
                Coaching coachingSession = await context
                    .Set<Coaching>()
                    .Include(c => c.Questions)
                    .FirstOrDefaultAsync(i => i.CoachingId == id) ?? throw new Exception("Null Reference");
                return coachingSession;
                 
            }
            catch
            {
                throw;
            }
        }
    }
}
