using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICartService _cartService;

        public ProductController(
            ICartRepository cartRepository,
            ICartService cartService
           )
        {
            _cartRepository = cartRepository;
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<IActionResult> Index(ProductCartViewModel productCartViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            productCartViewModel.CartItem.ProductId = productCartViewModel.Product.ProductId;
            string cartId = _cartService.GetCartId();
            Cart newCart = null;
            try
            {
                newCart = await _cartRepository.GetCart(cartId);
            }
            catch (Exception)
            {
                return new JsonResult(new { errors = "Something went wrong! Try again" });
            }

            List<CartItem> cartItems = newCart.CartItems
                .Where(ci => ci.Product.ProductId == productCartViewModel.Product.ProductId)
                .ToList();

            if (_cartService.AllowedQtyExceeds(cartItems, productCartViewModel))
            {
                return StatusCode(400, new
                {
                    error = @"You can only add 10 items per product. You have already added "
                                                     + _cartService.QtyTotal + " items."
                });
            }

            newCart = _cartService.AddItemToTheCart(cartItems, newCart, productCartViewModel);

            try
            {
                await _cartRepository.Update(newCart);
                return new JsonResult(new { data = newCart.CartItems.Count });
            }
            catch (Exception)
            {
                return StatusCode(400, new
                {
                    error = @"Error in adding item to the  cart"
                });
            }

        }
    }
}
