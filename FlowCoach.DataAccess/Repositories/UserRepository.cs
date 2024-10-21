using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
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
                if (context.Users.Any(u => u.Email == user.Email && u.Password == user.Password))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
