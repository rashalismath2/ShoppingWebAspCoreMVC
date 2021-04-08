using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository.RepositoryInterfaces
{
    public interface ICartRepository
    {
        Task<Cart> GetCart();
        Cart Create(Cart cart);
        Cart Update(Cart cart);
    }
}
