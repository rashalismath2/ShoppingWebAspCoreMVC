using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Repository.RepositoryInterfaces
{
    public interface ICheckoutRepository
    {
        Task<Checkout> Create(Checkout checkout);
        Task<List<Checkout>> RetrieveResultForPage(int userId, int? pageNumber, int resultsPerPage);
        Task<int> CheckoutLength();
    }
}
