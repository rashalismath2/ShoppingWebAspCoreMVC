using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        public ICartRepository CartRepository { get; }
        public ICheckoutRepository CheckoutRepository { get; }
        public ICartService CartService { get; }
        public IAuthService AuthService { get; }

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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string cartId = CartService.GetCartIdFromSession();
            Cart cart = await CartRepository.GetCart(cartId);

            var emptyCartValue = 1;

            if (cart.CartItems.Count < emptyCartValue)
            {
                TempData["ErrorMessage"] = "The cart is empty";
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            User user = await AuthService.GetAuthUser();

            Checkout checkout = new Checkout()
            {
                Cart = cart,
                UserId=user.UserId,
                FullName=user.FullName,
                Address=user.Address,
                Email=user.Email,
                Phone=user.ContactNumber
            };

            return View(checkout);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Checkout checkout)
        {

            string cartIdFromSession = CartService.GetCartIdFromSession();
            Cart cart = await CartRepository.GetCart(cartIdFromSession);

            if (ModelState.IsValid)
            {
                //TODO- ACID. Cart and Checkout saved seprately
                await CheckoutRepository.Create(checkout);

                cart=CartService.ProcessCart(cart);

                await CartRepository.Update(cart);

                CartService.ClearCartFromSession();

                TempData["SuccessMessage"] = "Checkout complete";

                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }


            checkout.Cart = cart;

            return View(checkout);
        }
    }
}
