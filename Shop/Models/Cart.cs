using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Cart
    {
        public string CartId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Cleared { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
    }
}
