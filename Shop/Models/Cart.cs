using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
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
        public List<CartItem> CartItems { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }

        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public float GetDiscount() {
            float itemDiscount = 0;
            if (CartItems.Count == 0)
            {
                return 0;
            }
            foreach (var item in CartItems)
            {
                itemDiscount += item.CalculateDiscount();
            }
            return itemDiscount;
        }
        public float GetSubTotal() {
            float itemSubTotal = 0;
            if (CartItems.Count == 0)
            {
                return 0;
            }
            foreach (var item in CartItems)
            {
                itemSubTotal += item.CalculateSubTotal();
            }
            return itemSubTotal;
        }
        public float GetTotal() {
            float itemTotal = 0;
            if (CartItems.Count==0) {
                return 0;
            }
            foreach (var item in CartItems)
            {
                itemTotal += item.CalculateTotal();
            }
            return itemTotal - GetDiscount();
        }
        public static string GetCartIdFromSession(IServiceProvider service) {

            ISession session = service.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            string cartId = session.GetString("cartId");

            if (cartId==null) {
                cartId = Guid.NewGuid().ToString();
                session.SetString("cartId", cartId);
            }

            return cartId;
        }
    }
}
