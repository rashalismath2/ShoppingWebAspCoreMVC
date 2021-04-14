using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CheckoutController : Controller
    {
        public CheckoutController(
                ICartRepository CartRepository,
                ICheckoutRepository CheckoutRepository,
                ICartService CartService, 
                IAuthService AuthService
            )
        {
            this.CartRepository = CartRepository;
            this.CheckoutRepository = CheckoutRepository;
            this.CartService = CartService;
            this.AuthService = AuthService;
        }

        public ICartRepository CartRepository { get; }
        public ICheckoutRepository CheckoutRepository { get; }
        public ICartService CartService { get; }
        public IAuthService AuthService { get; }

        public async Task<IActionResult> Index()
        {
            string cartId = CartService.GetCartIdFromSession();
            Cart cart = await CartRepository.GetCart(cartId);
            if (cart.CartItems.Count < 1)
            {
                TempData["ErrorMessage"] = "The cart is empty";
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            Checkout checkout = new Checkout()
            {
                Cart = cart,
            };
            return View(checkout);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Checkout checkout)
        {
            User user= AuthService.GetAuthUser();
            if (user!=null) {
                checkout.UserId = user.UserId;
            }
            await CheckoutRepository.Create(checkout);

            
            await CartService.ProcessCart();
            CartService.ClearCartFromSession();

            TempData["SuccessMessage"] = "Checkout complete";

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
