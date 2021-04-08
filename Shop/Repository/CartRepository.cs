using Microsoft.EntityFrameworkCore;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public class CartRepository : ICartRepository
    {
        public CartRepository(AppDbContext DbContext, IServiceProvider service)
        {
            this.DbContext = DbContext;
            Service = service;
        }

        public AppDbContext DbContext { get; }
        public IServiceProvider Service { get; }

        public Cart Create(Cart cart)
        {
            DbContext.Carts.Add(cart);
            DbContext.SaveChanges();
            return cart;
        }    
        public Cart Update(Cart cart)
        {
            DbContext.Carts.Update(cart);
            DbContext.SaveChanges();
            return cart;
        }

        public async Task<Cart>  GetCart()
        {
            string cartId = Cart.GetCartIdFromSession(Service);

            Cart cart = await DbContext.Carts.Include(c => c.CartItems).ThenInclude(ci=>ci.Product)
                .FirstOrDefaultAsync(c=>c.CartId== cartId);

            if (cart==null) {
                cart = Create(new Cart() { CartId=cartId});
            }

            return cart;
        }
    }
}
