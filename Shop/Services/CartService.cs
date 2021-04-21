using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class CartService : ICartService
    {
        public IServiceProvider ServiceProvider { get; }
        public ICartRepository CartRepository { get; }

        public CartService(IServiceProvider ServiceProvider, ICartRepository CartRepository)
        {
            this.ServiceProvider = ServiceProvider;
            this.CartRepository = CartRepository;
        }
        public string GetCartIdFromSession()
        {
            ISession session = ServiceProvider.GetRequiredService<IHttpContextAccessor>()
                                .HttpContext
                                .Session;

            string cartId = session.GetString("cartId");

            if (cartId == null)
            {
                cartId = Guid.NewGuid().ToString();
                session.SetString("cartId", cartId);
            }

            return cartId;
        }
        public string ClearCartFromSession()
        {
            ISession session = ServiceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            string cartId = session.GetString("cartId");
            session.Remove("cartId");
            return cartId;
        }

        public async Task<string> ProcessCart()
        {
            string cartId = GetCartIdFromSession();
            Cart cart = await CartRepository.GetCart(cartId);
            cart.Deleted = true;

            cart.ProcessCart();

            CartRepository.Update(cart);
            return cart.CartId;
        }


        public Cart AddItemToTheList(Cart cart, List<CartItem> cartItems, CartItem cartItem)
        {
            //if we have a product with same size in the cart items we just simply add two quentities
            bool foundProductWithSameSize = false;
            foreach (var item in cartItems)
            {
                if (item.Size == cartItem.Size)
                {
                    foundProductWithSameSize = true;
                    item.Qty += cartItem.Qty;
                }
            }
            //if we didnt found a product with the same size but different size we will add it to the cart
            if (!foundProductWithSameSize)
            {
                cart.CartItems.Add(cartItem);
            }

            return cart;
        }
    }
}
