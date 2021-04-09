using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository.RepositoryInterfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        Task<User> GetUserById(int userId);
    }
}
