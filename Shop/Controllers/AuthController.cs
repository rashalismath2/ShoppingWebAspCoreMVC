using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
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
        public IActionResult Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (AuthService.VerifyCredentials(login.Email, login.Password))
                    {
                        AuthService.Login(login.Email, login.RememberMe);

                        TempData["SuccessMessage"] = "Login successful";

                        return RedirectToRoute(new { controller = "Home", action = "Index" });
                    }


                    ModelState.AddModelError("Login", "Invalid email or password!");

                }
                catch (ArgumentException e)
                {
                    ModelState.AddModelError("Login", e.Message);
                }

            }

            return View(login);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            AuthService.Logout();
            TempData["SuccessMessage"] = "Logout successful";
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
