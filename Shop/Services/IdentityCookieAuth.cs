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
        private readonly IServiceProvider _service;
        private readonly IUserRepository _userRepository;

        public IdentityCookieAuth(IServiceProvider service, IUserRepository userRepository)
        {
            _service = service;
            _userRepository = userRepository;
        }

        public async Task<User> GetAuthUser()
        {
            string email = _service.GetRequiredService<IHttpContextAccessor>().HttpContext.User.Identity.Name;
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("User was not found");

            try
            {
                return await _userRepository.GetUserByEmail(email);
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public async Task<bool> Login(string email, bool rememberMe)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, email),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, "User")
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe
            };

            try
            {
                await _service.GetRequiredService<IHttpContextAccessor>().HttpContext.SignInAsync(
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
                await _service.GetRequiredService<IHttpContextAccessor>().HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> CredentialsAreValid(string email, string password)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email cant be empty!");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("Password cant be empty!");

            bool isVerfied = false;

            User user = await _userRepository.GetUserByEmail(email);

            if (user == null)
            {
                throw new ArgumentException("Provided email was not found. IF you havend already signed in please signup");
            };

            bool passwordsAreTheSame = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (passwordsAreTheSame) isVerfied = true;

            return isVerfied;
        }
    }
}
