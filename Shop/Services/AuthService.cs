using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
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

        public User GetAuthUser()
        {
            User user = null;
            if (Session.GetString("UserEmail") != null)
            {
                string email = Session.GetString("UserEmail");
                user = UserRepository.GetUserByEmail(email);
            }

            return user;
        }

        public void Login(string email,bool rememberMe)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");

            Session.SetString("UserEmail", email);
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool VerifyCredentials(string email, string password)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("Password cant be empty!");

            bool isVerfied = false;

            User user = UserRepository.GetUserByEmail(email);

            if (user == null)
            {
                return isVerfied;
            };

            bool emailsAreTheSame = user.Email.ToLower().Equals(email.ToLower());

            bool passwordsAreTheSame = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (emailsAreTheSame && passwordsAreTheSame) isVerfied = true;

            return isVerfied;
        }
    }
}
