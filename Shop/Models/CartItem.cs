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
        public Cart Cart { get; set; }
        public int CartId { get; set; }
        public int Qty { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
    }
}
