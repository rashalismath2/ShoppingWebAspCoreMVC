using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository;
using Shop.Core.Repository.RepositoryInterfaces;
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
        public CartViewComponent(ICartRepository cartRepo, ICartService cartService)
        {
            CartRepo = cartRepo;
            this.CartService = cartService;
        }

        public ICartRepository CartRepo { get; }
        public ICartService CartService { get; }

        public async Task<IViewComponentResult> InvokeAsync() {
            string cartId = CartService.GetCartId();
            Cart cart = await CartRepo.GetCart(cartId);
            cart.ProcessCart();
            return View(cart);
        }
    }
}
