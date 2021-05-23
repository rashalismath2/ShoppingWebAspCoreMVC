using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class CartService : ICartService
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly ICartRepository _cartRepository;
        public int QtyTotal { get;  set; }
        public CartService(IServiceProvider serviceProvider, ICartRepository cartRepository)
        {
            _serviceProvider = serviceProvider;
            _cartRepository = cartRepository;
        }
        public string GetCartId()
        {
            var httpContext = _serviceProvider.GetRequiredService<IHttpContextAccessor>()
                                .HttpContext;

            var cartIdFromCookie = httpContext.Request.Cookies["cartId"];

            if (cartIdFromCookie == null)
            {
                cartIdFromCookie = Guid.NewGuid().ToString();
                CookieOptions option = new CookieOptions();

                option.Expires = DateTime.Now.AddDays(10);
                option.HttpOnly = true;

                httpContext.Response.Cookies.Append("cartId", cartIdFromCookie, option);
            }

            return cartIdFromCookie;
        }
        public string ClearCart()
        {
            var httpContext = _serviceProvider.GetRequiredService<IHttpContextAccessor>()
                             .HttpContext;

            string cartId = httpContext.Request.Cookies["cartId"];
            httpContext.Response.Cookies.Delete("cartId");

            return cartId;
        }

        public Cart ProcessCart(Cart cart)
        {
            cart.processed = true;
            cart.ProcessCart();
            return cart;
        }

        public bool AllowedQtyExceeds(List<CartItem> cartItems, ProductCartViewModel productCartViewModel)
        {
            //calculating qty will be determined by only the product id, size wont be included
            //total of the qty exist in the cart and we are adding should be less than 10
            int qtyTotal = cartItems.Sum(s => s.Qty);
            int totalItemsToBeAdded = qtyTotal + productCartViewModel.CartItem.Qty;
            int allowedItemsToBeAdded = 10;

            if (totalItemsToBeAdded > allowedItemsToBeAdded)
            {
                QtyTotal = qtyTotal;
                return true;
            }
            else return false;

        }
        public Cart AddItemToTheCart(List<CartItem> cartItems, Cart newCart, ProductCartViewModel productCartViewModel)
        {
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

            return newCart;
        }
    }
}
