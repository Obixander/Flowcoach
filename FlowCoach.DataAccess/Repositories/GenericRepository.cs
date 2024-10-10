﻿using FlowCoach.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async void Add(T entity)
        {
            try
            {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void Delete(T entity)
        {
            try
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void DeleteAt(int id)
        {
            try
            {
                context.Remove(id);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await context.Set<T>().AsNoTracking().ToListAsync(); //no tracking as the is returns to the client and is not needed to be tracked
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> GetBy(int id)
        {
            try
            {
                return await context.FindAsync<T>(id) ?? throw new Exception();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async void Update(T entity)
        {
            try
            {
                context.Update(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
