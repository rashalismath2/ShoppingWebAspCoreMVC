using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Repository
{
    public class CheckoutRepository : ICheckoutRepository
    {
        public CheckoutRepository(AppDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public AppDbContext DbContext { get; }

        public async Task<Checkout> Create(Checkout checkout)
        {
            await DbContext.AddAsync(checkout);
            DbContext.SaveChanges();
            return checkout;
        }
    }
}
