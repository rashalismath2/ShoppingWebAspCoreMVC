﻿using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CheckoutController : Controller
    {
        public CheckoutController(ICartRepository CartRepository, ICheckoutRepository CheckoutRepository, IServiceProvider Service)
        {
            this.CartRepository = CartRepository;
            this.CheckoutRepository = CheckoutRepository;
            this.Service = Service;
        }

        public ICartRepository CartRepository { get; }
        public ICheckoutRepository CheckoutRepository { get; }
        public IServiceProvider Service { get; }

        public async Task<IActionResult> Index()
        {
            Cart cart = await CartRepository.GetCart();
            if (cart.CartItems.Count<1) {
                TempData["ErrorMessage"] = "The cart is empty";
                return RedirectToRoute(new { controller="Home",action="Index"});
            }
            Checkout checkout = new Checkout() {
                Cart = cart
            };
            return View(checkout);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Checkout checkout) {

            await CheckoutRepository.Create(checkout);

            Cart cart = await CartRepository.GetCart();
            cart.Deleted = true;

            cart.GetDiscount();
            cart.GetSubTotal();
            cart.GetTotal();

            CartRepository.Update(cart);

            Cart.ClearCartFromSession(Service);

            TempData["SuccessMessage"] = "Checkout complete";

            return RedirectToRoute(new { controller="Home", action="Index"});
        }
    }
}
