using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Cart Cart { get; set; }
        public string CartId { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float DiscountPrecentage { get; set; }
    }
}
