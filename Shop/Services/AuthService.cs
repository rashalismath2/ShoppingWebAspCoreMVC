using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IServiceProvider _service;
        private readonly ISession _session;
        private readonly IUserRepository _userRepository;

        public AuthService(IServiceProvider service, IUserRepository userRepository)
        {
            this._service = service;
            this._userRepository = userRepository;
            _session = service.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
        }

        public async Task<User> GetAuthUser()
        {
            User user = null;
            if (_session.GetString("UserEmail") != null)
            {
                string email = _session.GetString("UserEmail");
                user = await _userRepository.GetUserByEmail(email);
            }
            return user;
        }

        public Task<bool> Login(string email,bool rememberMe)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");
            _session.SetString("UserEmail", email);

            return Task.FromResult(false);
        }

        public Task<bool> Logout()
        {
            _session.Remove("UserEmail");
            return Task.FromResult(false);
        }

        public async Task<bool> CredentialsAreValid(string email, string password)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("Password cant be empty!");

            bool isVerfied = false;

            User user =await _userRepository.GetUserByEmail(email);

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
