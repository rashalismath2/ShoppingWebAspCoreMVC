using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class Checkout
    {
        public int CheckoutId { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
        public Cart Cart { get; set; }
        public string CartId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public City City { get; set; }
        public string Note { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
