using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ProductCartViewModel
    {
        public Product Product { get; set; }
        public CartItem CartItem { get; set; }
        public ProductCartViewModel()
        {

        }
    }
}
