using Microsoft.EntityFrameworkCore;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repository
{
    public class CartRepository : ICartRepository
    {
        public CartRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

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

        public async Task<Cart> GetCart(string cartId)
        {
            Cart cart = await DbContext.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.CartId == cartId);

            if (cart == null)
            {
                cart = Create(new Cart() { CartId = cartId });
            }

            return cart;
        }
    }
}
