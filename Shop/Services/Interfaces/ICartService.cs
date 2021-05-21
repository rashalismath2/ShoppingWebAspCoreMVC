using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces
{
    public interface ICartService
    {
        string GetCartId();
        string ClearCart();
        Cart ProcessCart(Cart cart);
    }
}
