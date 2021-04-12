using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository.RepositoryInterfaces
{
    public interface ICartItemRepository
    {
       Task<CartItem> DeleteById(int id);
    }
}
