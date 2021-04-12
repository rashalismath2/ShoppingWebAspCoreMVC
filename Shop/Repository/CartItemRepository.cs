using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        public CartItemRepository(AppDbContext DbContext)
        {
            this.DbContext = DbContext;
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
