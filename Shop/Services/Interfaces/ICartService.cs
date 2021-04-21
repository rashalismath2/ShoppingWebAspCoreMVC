using Shop.Core.Models;
using Shop.Core.Models.Enums;
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
        Task<string> ProcessCart();
        public int AllowedItemsPerProduct { get { return 10; } }

        Cart AddItemToTheCart(Cart cart,List<CartItem> cartItems, CartItem cartItem);
    }
}
