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
        private readonly AppDbContext _dbContext;
        public CheckoutRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CheckoutLength()
        {
            return await _dbContext.Checkouts.CountAsync() ;
        }

        public async Task<Checkout> Create(Checkout checkout)
        {
            _dbContext.Add(checkout);
            await _dbContext.SaveChangesAsync();
            return checkout;
        }

        public async Task<List<Checkout>> RetrieveResultForPage(int userId,int? pageNumber, int resultsPerPage) {

            if (pageNumber != null && pageNumber > 1)
            {
                return await _dbContext.Checkouts.
                     Where(checkout => checkout.UserId == userId)
                     .Skip(resultsPerPage * ((int)pageNumber - 1))
                     .Take(resultsPerPage)
                     .Include(checkout => checkout.Cart)
                     .ThenInclude(cart => cart.CartItems)
                     .ThenInclude(cartItem => cartItem.Product)
                     .ToListAsync();
            }

            return await _dbContext.Checkouts.
                   Where(checkout => checkout.UserId == userId)
                    .Take(resultsPerPage)
                   .Include(checkout => checkout.Cart)
                   .ThenInclude(cart => cart.CartItems)
                   .ThenInclude(cartItem => cartItem.Product)
                   .ToListAsync();
        }
    }
}
