using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces
{
    public interface IAuthService
    {
        User GetAuthUser();
        void Login(string email,bool rememberMe);
        bool VerifyCredentials(string email,string password);
        void Logout();
    }
}
