using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Services.Interfaces
{
    public interface IApiBase<T> where T : class
    {
        //Generic methods
        Task<IEnumerable<T>> GetAll();
        Task<T> GetBy(int Id);
        Task<T> Post(T Entity);
        Task Put(T Entity);
        Task Delete(T Entity);
    }
}
