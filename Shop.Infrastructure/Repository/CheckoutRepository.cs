using Microsoft.EntityFrameworkCore;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repository
{
    public class CheckoutRepository : ICheckoutRepository
    {
        public CheckoutRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

        public async Task<int> CheckoutLength()
        {
            return await DbContext.Checkouts.CountAsync() ;
        }

        public async Task<Checkout> Create(Checkout checkout)
        {
            await DbContext.AddAsync(checkout);
            DbContext.SaveChanges();
            return checkout;
        }

        public async Task<List<Checkout>> RetrieveResultForPage(int userId,int? pageNumber, int resultsPerPage) {

            if (pageNumber != null && pageNumber > 1)
            {
                return await DbContext.Checkouts.
                     Where(checkout => checkout.UserId == userId)
                     .Skip(resultsPerPage * ((int)pageNumber - 1)).Take(resultsPerPage)
                     .Include(checkout => checkout.Cart)
                     .ThenInclude(cart => cart.CartItems)
                     .ThenInclude(cartItem => cartItem.Product)
                     .ToListAsync();
            }

            return await DbContext.Checkouts.
                   Where(checkout => checkout.UserId == userId)
                    .Take(resultsPerPage)
                   .Include(checkout => checkout.Cart)
                   .ThenInclude(cart => cart.CartItems)
                   .ThenInclude(cartItem => cartItem.Product)
                   .ToListAsync();
  

        }
    }
}
