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
        public CartItemRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

        public async Task<CartItem> DeleteById(int id)
        {
            CartItem cartItem=await DbContext.CartItems.FindAsync(id);
            if (cartItem != null) {
                DbContext.CartItems.Remove(cartItem);
                await DbContext.SaveChangesAsync();
            }

            return cartItem;
        }
    }
}
