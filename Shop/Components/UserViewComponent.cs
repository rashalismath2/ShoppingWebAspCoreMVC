using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Components
{
    public class UserViewComponent : ViewComponent
    {
        public UserViewComponent(IAuthService authService)
        {

            this.AuthService = authService;
        }

        public IAuthService AuthService { get; }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                User user = await AuthService.GetAuthUser();
                return View(user);
            }
            catch (ArgumentException)
            {
                return View(new User());
            }   
            catch (Exception)
            {
                return View(new User());
            }

        }

    }
}
