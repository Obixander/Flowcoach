using FlowCoach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.DataAccess.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
         bool Login(User user); //this is a method that will be used to login a user true means it was accept and false means either password or email was wrong

    }
}
