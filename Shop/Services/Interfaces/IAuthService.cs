using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces
{
    public interface IAuthService
    {
        User GetAuthUser();
        Task<bool> Login(string email,bool rememberMe);
        bool CredentialsAreValid(string email,string password);
        Task<bool> Logout();
    }
}
