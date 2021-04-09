using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services
{
    public interface IAuthService
    {
        Task<User> GetAuthUserAsync();
        void SetAuthUser(int userId, string firstName);
    }
}
