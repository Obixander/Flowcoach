using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task DeleteAt(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetBy(int id);
    }
}
