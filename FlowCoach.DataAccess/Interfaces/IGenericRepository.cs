using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Interfaces
{
    public interface IGenericRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteAt(int id);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }
}
