using FlowCoach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Interfaces
{
    public interface ICoachingRepository : IGenericRepository<Coaching>
    {
        public Task<Coaching> GetByAsync(int id);
    }
}
