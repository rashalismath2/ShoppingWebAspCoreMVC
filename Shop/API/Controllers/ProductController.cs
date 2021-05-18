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
        public ProductController(IProductRepository products, ICartRepository cartRepository, ICartService cartService, IProductService productService)
        {
            ProductsRepository = products;
            CartRepository = cartRepository;
            this.CartService = cartService;
            this.productService = productService;
        }

        private readonly IProductService productService;
        public IProductRepository ProductsRepository { get; }
        public ICartRepository CartRepository { get; }
        public ICartService CartService { get; }

        [HttpPost]
        public async Task<IActionResult> Index( ProductCartViewModel productCartViewModel)
        {
            string cartId = CartService.GetCartIdFromSession();
            Cart newCart = await CartRepository.GetCart(cartId);
            productCartViewModel.CartItem.ProductId = productCartViewModel.Product.ProductId;

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            List<CartItem> cartItems = newCart.CartItems
                .Where(ci => ci.Product.ProductId == productCartViewModel.Product.ProductId)
                .ToList();

            //calculating qty will be determined by only the product id, size wont be included
            //total of the qty exist in the cart and we are adding should be less than 10
            int qtyTotal = cartItems.Sum(s => s.Qty);
            int totalItemsToBeAdded = qtyTotal + productCartViewModel.CartItem.Qty;
            int allowedItemsToBeAdded = 10;

            if (totalItemsToBeAdded > allowedItemsToBeAdded)
            {

                return StatusCode(400,new { error = @"You can only add 10 items per product. You have already added "
                                                     + qtyTotal + " items." });
            }


            //if we have a product with same size in the cart items we just simply add two quentities
            bool foundProductWithSameSize = false;
            foreach (var item in cartItems)
            {
                if (item.Size == productCartViewModel.CartItem.Size)
                {
                    foundProductWithSameSize = true;
                    item.Qty += productCartViewModel.CartItem.Qty;
                }
            }
            //if we didnt found a product with the same size but different size we will add it to the cart
            if (!foundProductWithSameSize)
            {
                newCart.CartItems.Add(productCartViewModel.CartItem);
            }

            try
            {
                await CartRepository.Update(newCart);

                return Ok(new { data = newCart.CartItems.Count });
            }
            catch (Exception)
            {
                return StatusCode(400,new
                {
                    error = @"Error in adding item to the  cart"
                });
            }

        }
    }
}
