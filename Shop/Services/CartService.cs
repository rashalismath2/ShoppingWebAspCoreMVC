using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
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

            ISession session = ServiceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
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
            Cart cart = await CartRepository.GetCart();
            cart.Deleted = true;

            cart.ProcessCart();

            CartRepository.Update(cart);
            return cart.CartId;
        }
    }
}
