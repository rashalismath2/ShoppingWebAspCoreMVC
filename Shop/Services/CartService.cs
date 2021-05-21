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
        public string GetCartId()
        { 
            var httpContext = ServiceProvider.GetRequiredService<IHttpContextAccessor>()
                                .HttpContext;
            ISession session = httpContext.Session;

            var cartIdFromCookie = httpContext.Request.Cookies["cartId"];
            string cartIdFromSession = session.GetString("cartId");
            if (cartIdFromCookie == null && cartIdFromSession == null)
            {
                cartIdFromSession = Guid.NewGuid().ToString();
                session.SetString("cartId", cartIdFromSession);

                CookieOptions option = new CookieOptions();

                option.Expires = DateTime.Now.AddDays(10);
                option.HttpOnly = true;

                httpContext.Response.Cookies.Append("cartId", cartIdFromSession, option);
            }

            if (cartIdFromCookie != null && cartIdFromSession == null)
            {
                cartIdFromSession = cartIdFromCookie;
                session.SetString("cartId", cartIdFromSession);
            }


            return cartIdFromSession;
        }
        public string ClearCart()
        {
            ISession session = ServiceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            string cartId = session.GetString("cartId");
            session.Remove("cartId");

            var httpContext = ServiceProvider.GetRequiredService<IHttpContextAccessor>()
                               .HttpContext;
            httpContext.Response.Cookies.Delete("cartId");

            return cartId;
        }

        public Cart ProcessCart(Cart cart)
        {
            cart.Deleted = true;
            cart.ProcessCart();
            return cart;
        }
    }
}
