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
    public class UserRepository(DataContext context) : GenericRepository<User>(context), IUserRepository
    {
        public async Task<bool> Login(User user)
        {
            try
            {
                bool userExists = await context.Users
                .AnyAsync(u => u.Email == user.Email && u.Password == u.Password);

                return userExists;
            }
            catch
            {
                throw;
            }
        }

    }
}
