using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
using System;
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

        [AllowAnonymous]
        public IActionResult Login([FromQuery] string ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool credentialsAreValid = await AuthService.CredentialsAreValid(login.Email, login.Password);
                    bool loginIsSuccess = await AuthService.Login(login.Email, login.RememberMe);

                    if (credentialsAreValid && loginIsSuccess)
                    {
                        TempData["SuccessMessage"] = "Login successful";
                        if (login.ReturnUrl != null)
                        {
                            return Redirect(login.ReturnUrl);
                        }
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
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {

            bool logoutSuccessful = await AuthService.Logout();

            if (logoutSuccessful)
            {
                TempData["SuccessMessage"] = "Logout successful";
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            };

            TempData["ErrorMessage"] = "Logout was not successful";

            return RedirectToRoute(new { controller = "Home", action = "Index" });

        }
    }
}
