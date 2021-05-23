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
        private readonly AppDbContext _dbContext;
        public CartRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Cart Create(Cart cart)
        {
            _dbContext.Carts.Add(cart);
            _dbContext.SaveChanges();
            return cart;
        }
        public async Task<Cart> Update(Cart cart)
        {
            _dbContext.Carts.Update(cart);
            await _dbContext.SaveChangesAsync();
            return cart;
        }

        public async Task<Cart> GetCart(string cartId)
        {
            Cart cart = await _dbContext.Carts
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
