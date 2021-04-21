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
        public AuthController(IUserRepository userRepository, IAuthService authService)
        {
            this.UserRepository = userRepository;
            this.AuthService = authService;
        }

        public IUserRepository UserRepository { get; }
        public IAuthService AuthService { get; }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool credentialsAreValid = AuthService.CredentialsAreValid(login.Email, login.Password);
                    bool loginIsSuccess = await AuthService.Login(login.Email, login.RememberMe);

                    if (credentialsAreValid && loginIsSuccess)
                    {
                        TempData["SuccessMessage"] = "Login successful";
                        return RedirectToRoute(new { controller = "Home", action = "Index" });
                    }

                    ModelState.AddModelError("Login", "Invalid email or password!");
                }
                catch (ArgumentException e)
                {
                    ModelState.AddModelError("Login", e.Message);
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError("Login", exception.Message);
                }
            }

            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            try
            {
                bool logoutSuccessful = await AuthService.Logout();

                if (logoutSuccessful)
                {
                    TempData["SuccessMessage"] = "Logout successful";
                    return RedirectToRoute(new { controller = "Home", action = "Index" });
                };
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Logout was not successful";
            }
            return RedirectToRoute(new { controller = "Home", action = "Index" });

        }
    }
}
