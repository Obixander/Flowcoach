using FlowCoach.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Repositories
{
    public class GenericRepository<T>(DataContext context) : IGenericRepository<T> where T : class
    {
        //i want to do this all async but i dont know if it makes much sense

        public void Add(T entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                context.Remove(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteAt(int id)
        {
            try
            {
                context.Remove(id);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetBy(int id)
        {
            try
            {
                return context.Find<T>(id) ?? throw new Exception("Entity not found");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Update(T entity)
        {
            try
            {
                context.Update(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
