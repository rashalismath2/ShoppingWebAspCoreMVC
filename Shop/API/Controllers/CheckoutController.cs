using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Dto;
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
        private readonly IMapper _mapper;
        private readonly ICartRepository _cartRepository;
        private readonly ICheckoutRepository _checkoutRepository;
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;

        public CheckoutController(
                ICartRepository cartRepository,
                ICheckoutRepository checkoutRepository,
                ICartService cartService,
                IAuthService authService,
                IUserRepository userRepository,
                IMapper mapper
            )
        {
            this._cartRepository = cartRepository;
            this._checkoutRepository = checkoutRepository;
            this._cartService = cartService;
            this._authService = authService;
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Checkout([FromBody] CheckoutForCreate checkoutForCreate)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(ModelState);
            }

            string cartId = _cartService.GetCartId();
            Cart cart = await _cartRepository.GetCart(cartId);
            if (cart.CartItems.Count < 1) return BadRequest(new { errors = "Cart items cant be zero" });
            checkoutForCreate.CartId = cart.CartId;

            var authUser = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name);
            checkoutForCreate.UserId = authUser.UserId;

            checkoutForCreate.Date = DateTime.Now;

            var checkout = _mapper.Map<Checkout>(checkoutForCreate);

            cart = _cartService.ProcessCart(cart);

            await _checkoutRepository.Create(checkout);
            await _cartRepository.Update(cart);

            _cartService.ClearCart();

            return NoContent();
        }
    }
}
