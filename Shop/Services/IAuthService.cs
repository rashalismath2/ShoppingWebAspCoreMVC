using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services
{
    public interface IAuthService
    {
        User GetAuthUser();
        void SetAuthUser(string firstName);
        bool VerifyCredentials(string email,string password);
    }
}
