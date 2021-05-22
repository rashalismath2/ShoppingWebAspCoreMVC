
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class Cart
    {
        public string CartId { get; set; }
        public float Total { get; private set; }
        public float SubTotal { get; private set; }
        public float Discount { get; private set; }
        public bool processed { get;  set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public float GetDiscount()
        {
            Discount = 0;

            foreach (var item in CartItems)
            {
                Discount += item.GetDiscount();
            }
            return Discount;
        }
        public float GetSubTotal()
        {
            SubTotal = 0;
            foreach (var item in CartItems)
            {
                SubTotal += item.GetSubTotal();
            }
            return SubTotal;
        }
        public float GetTotal()
        {
            if (Discount!=0 && SubTotal!=0) {
                return Total = SubTotal - Discount;
            }
            return Total = GetSubTotal() - GetDiscount();
        }

        public void ProcessCart()
        {
            GetDiscount();
            GetSubTotal();
            GetTotal();
        }

    }
}
