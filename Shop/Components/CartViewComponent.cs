using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository;
using Shop.Repository.RepositoryInterfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Components
{
    public class CartViewComponent : ViewComponent
    {
        public CartViewComponent(ICartRepository cartRepo)
        {
            CartRepo = cartRepo;
        }

        public ICartRepository CartRepo { get; }

        public async Task<IViewComponentResult> InvokeAsync() {
            Cart cart = await CartRepo.GetCart();
            return View(cart);
        }
    }
}
