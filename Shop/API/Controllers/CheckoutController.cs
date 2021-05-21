using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/checkout")]
    [Authorize]
    [ApiController]
    public class CheckoutController : ControllerBase
    {

        private readonly IUserRepository _userRepository;
        public ICartRepository CartRepository { get; }
        public ICheckoutRepository CheckoutRepository { get; }
        public ICartService CartService { get; }
        public IAuthService AuthService { get; }

        public CheckoutController(
                ICartRepository CartRepository,
                ICheckoutRepository CheckoutRepository,
                ICartService CartService,
                IAuthService AuthService,
                IUserRepository userRepository
            )
        {
            this.CartRepository = CartRepository;
            this.CheckoutRepository = CheckoutRepository;
            this.CartService = CartService;
            this.AuthService = AuthService;
            this._userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Checkout([FromBody]Checkout checkout)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(ModelState);
            }

            string cartIdFromSession = CartService.GetCartId();
            Cart cart = await CartRepository.GetCart(cartIdFromSession);

            if (cart.CartItems.Count < 1)
            {
                return BadRequest(new {errors="Cart items cant be zero" });
            }

            var authUser = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name);
            checkout.UserId = authUser.UserId;

            //TODO- ACID. Cart and Checkout saved seprately
            checkout.Date = DateTime.Now;
            await CheckoutRepository.Create(checkout);

            cart = CartService.ProcessCart(cart);

            await CartRepository.Update(cart);

            CartService.ClearCart();


            return NoContent();
        }
    }
}
