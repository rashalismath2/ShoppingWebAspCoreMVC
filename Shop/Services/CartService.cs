using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Models;
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

        public CartService(IServiceProvider serviceProvider, ICartRepository cartRepository)
        {
            this.ServiceProvider = serviceProvider;
            this.CartRepository = cartRepository;
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

        public  Cart ProcessCart(Cart cart)
        {
            cart.Deleted = true;
            cart.ProcessCart();
            return cart;
        }
    }
}
