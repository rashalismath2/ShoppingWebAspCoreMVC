using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Models.Auth;
using Shop.Repository.RepositoryInterfaces;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class AuthController : Controller
    {
        public AuthController(IUserRepository UserRepository, IAuthService AuthService)
        {
            this.UserRepository = UserRepository;
            this.AuthService = AuthService;
        }

        public IUserRepository UserRepository { get; }
        public IAuthService AuthService { get; }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                User user = UserRepository.GetUserByEmail(login.Email);

                bool verified = BCrypt.Net.BCrypt.Verify(login.Password, user.Password);

                if (verified && (user.Email.ToLower() == login.Email.ToLower()))
                {
                    AuthService.SetAuthUser(user.UserId, user.FirstName);

                    TempData["LoginSuccessMessage"] = "Login successful";
                    return RedirectToRoute(new { controller = "Home", action = "Index" });
                }
            }

            ModelState.AddModelError("Login","Invalid email and password!");

            return View(login);
        }
    }
}
