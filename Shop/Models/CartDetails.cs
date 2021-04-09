using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CartDetails
    {
        public CartDetails(List<CartItem> CartItems)
        {
            this.CartItems = CartItems;
            SetValues();
        }

        public List<CartItem> CartItems { get; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }


        public void SetValues() {
            if (CartItems!=null && CartItems.Count>0) {
                Product = CartItems.First().Product;
            }
            foreach (var item in CartItems)
            {
                Qty += item.Qty;
                Total += item.CalculateTotal();
                Discount += item.CalculateDiscount();
                SubTotal += item.CalculateSubTotal();
            }
        }
    }
}
