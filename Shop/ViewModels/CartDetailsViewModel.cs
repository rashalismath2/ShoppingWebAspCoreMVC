using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class CartDetailsViewModel
    {
        public CartDetailsViewModel(Cart cart, List<CartDetails> CartDetails)
        {
            Cart = cart;
            this.CartDetails = CartDetails;
        }

        public Cart Cart { get; set; }
        public List<CartDetails> CartDetails { get; }
    }
}
