﻿using Microsoft.AspNetCore.Http;
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

        public IServiceProvider Service { get; }
        public IUserRepository UserRepository { get; }
        public IAuthService AuthService { get; }

        
        public IViewComponentResult Invoke() {

            return View(AuthService.GetAuthUser());
        }

    }
}
