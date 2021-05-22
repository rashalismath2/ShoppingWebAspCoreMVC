using Shop.Core.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces
{
    public interface ICartService
    {
        public int QtyTotal { get; set; }
        string GetCartId();
        string ClearCart();
        Cart ProcessCart(Cart cart);
        Cart AddItemToTheCart(List<CartItem> cartItems,Cart newCart, ProductCartViewModel productCartViewModel);
        bool AllowedQtyExceeds(List<CartItem> cartItems, ProductCartViewModel productCartViewModel);
    }
}
