using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class AuthService : IAuthService
    {

        public AuthService(IServiceProvider Service, IUserRepository UserRepository)
        {
            this.Service = Service;
            this.UserRepository = UserRepository;

            Session = Service.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
        }

        public IServiceProvider Service { get; }
        public ISession Session { get; }
        public IUserRepository UserRepository { get; }

        public async Task<User> GetAuthUserAsync()
        {
            if (Session.GetInt32("UserId").HasValue)
            {
                int userId = Session.GetInt32("UserId").Value;
                User user = await UserRepository.GetUserById(userId);
                return user;
            }

            return null;
        }

        public void SetAuthUser(int userId, string firstName)
        {

            Session.SetString("UserFirstName", firstName);
            Session.SetInt32("UserId", userId);
        }
    }
}
