using Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ProductSize Size { get; set; }
        public ProductColor Color { get; set; }
        public Cart Cart { get; set; }
        public int Qty { get; set; }

        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }

        public float CalculateTotal() {

            if (Product != null)
            {
                return (Product.Price * Qty) - CalculateDiscount();
            }
            return 0;
        }
        public float CalculateSubTotal()
        {
            if (Product != null)
            {
                return (Product.Price * Qty);
            }
            return 0;
        }
        public float CalculateDiscount()
        {
            if (Product != null)
            {
                return Product.DiscountPrecentage * Product.Price * Qty / 100;
            }
            return 0;
        }
        


    }
}
