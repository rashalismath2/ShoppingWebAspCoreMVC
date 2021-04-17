
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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<CartItem> CartItems { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
        public bool Deleted { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public float GetDiscount() {
            float itemDiscount = 0;
            if (CartItems.Count == 0)
            {
                Discount = 0;
                return Discount;
            }
            foreach (var item in CartItems)
            {
                itemDiscount += item.CalculateDiscount();
            }
            Discount = itemDiscount;
            return Discount;
        }
        public float GetSubTotal() {
            float itemSubTotal = 0;
            if (CartItems.Count == 0)
            {
                SubTotal = 0;
                return SubTotal;
            }
            foreach (var item in CartItems)
            {
                itemSubTotal += item.CalculateSubTotal();
            }
            SubTotal = itemSubTotal;
            return SubTotal;
        }
        public float GetTotal() {
            if (CartItems.Count==0) {
                Total = 0;
                return Total;
            }
      
            Total = GetSubTotal() - GetDiscount();
            return Total;
        }

        public void ProcessCart() {
            GetDiscount();
            GetSubTotal();
            GetTotal();
        }

    }
}
