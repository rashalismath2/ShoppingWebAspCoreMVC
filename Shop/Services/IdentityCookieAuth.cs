using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
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
        public IdentityCookieAuth(IServiceProvider Service, IUserRepository UserRepository)
        {
            this.Service = Service;
            this.UserRepository = UserRepository;
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

        public async void Login(string email, bool rememberMe)
        {
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

            await Service.GetRequiredService<IHttpContextAccessor>().HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

        }

        public async void Logout()
        {
            await Service.GetRequiredService<IHttpContextAccessor>().HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
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
