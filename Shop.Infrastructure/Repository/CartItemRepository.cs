using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly AppDbContext _dbContext;

        public CartItemRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CartItem> DeleteById(int id)
        {
            CartItem cartItem = await _dbContext.CartItems.FindAsync(id);
            if (cartItem != null)
            {
                _dbContext.CartItems.Remove(cartItem);
                await _dbContext.SaveChangesAsync();
            }
            return cartItem;
        }
    }
}
