using Microsoft.EntityFrameworkCore;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public class CartRepository : ICartRepository
    {
        public CartRepository(AppDbContext DbContext,ICartService CartService)
        {
            this.DbContext = DbContext;
            this.CartService = CartService;
        }

        public AppDbContext DbContext { get; }
        public ICartService CartService { get; }

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
            string cartId = CartService.GetCartIdFromSession();

            Cart cart = await DbContext.Carts.Include(c => c.CartItems).ThenInclude(ci=>ci.Product)
                .FirstOrDefaultAsync(c=>c.CartId== cartId);

            if (cart==null) {
                cart = Create(new Cart() { CartId=cartId});
            }

            return cart;
        }
    }
}
