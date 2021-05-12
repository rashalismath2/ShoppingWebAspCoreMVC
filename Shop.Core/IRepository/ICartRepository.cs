using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Repository.RepositoryInterfaces
{
    public interface ICartRepository
    {
        Task<Cart> GetCart(string cartId);
        Cart Create(Cart cart);
        Task<Cart> Update(Cart cart);
    }
}
