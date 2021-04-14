﻿using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository;
using Shop.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Components
{
    public class CartViewComponent : ViewComponent
    {
        public CartViewComponent(ICartRepository cartRepo, ICartService CartService)
        {
            CartRepo = cartRepo;
            this.CartService = CartService;
        }

        public ICartRepository CartRepo { get; }
        public ICartService CartService { get; }

        public async Task<IViewComponentResult> InvokeAsync() {
            string cartId = CartService.GetCartIdFromSession();
            Cart cart = await CartRepo.GetCart(cartId);
            return View(cart);
        }
    }
}
