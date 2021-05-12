using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces
{
    public interface ICartService
    {
        string GetCartIdFromSession();
        string ClearCartFromSession();
        Cart ProcessCart(Cart cart);
    }
}
