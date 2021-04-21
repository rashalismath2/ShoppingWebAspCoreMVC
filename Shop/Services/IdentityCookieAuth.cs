using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class IdentityCookieAuth : IAuthService
    {
        public IdentityCookieAuth(IServiceProvider service, IUserRepository userRepository)
        {
            this.Service = service;
            this.UserRepository = userRepository;
        }

        public IServiceProvider Service { get; }
        public IUserRepository UserRepository { get; }

        public User GetAuthUser()
        {
            string email = Service.GetRequiredService<IHttpContextAccessor>().HttpContext.User.Identity.Name;
            //TODO dependecy to repository from service. Is it okay?
            if (!string.IsNullOrWhiteSpace(email))
            {
                return UserRepository.GetUserByEmail(email);
            };
            return null;
        }

        public async Task<bool> Login(string email, bool rememberMe)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, email),
                new Claim("Email", email),
                new Claim(ClaimTypes.Role, "User"),
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe
            };

            try
            {
                await Service.GetRequiredService<IHttpContextAccessor>().HttpContext.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      new ClaimsPrincipal(claimsIdentity),
                      authProperties
                    );

                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public async Task<bool> Logout()
        {
            try
            {
                await Service.GetRequiredService<IHttpContextAccessor>().HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool CredentialsAreValid(string email, string password)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("Password cant be empty!");

            bool isVerfied = false;

            User user = UserRepository.GetUserByEmail(email);

            if (user == null)
            {
                return isVerfied;
            };

            bool passwordsAreTheSame = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (passwordsAreTheSame) isVerfied = true;

            return isVerfied;
        }
    }
}
