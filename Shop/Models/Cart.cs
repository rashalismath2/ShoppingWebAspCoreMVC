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
        public IEnumerable<CartItem> CartItems { get; set; }
        public float Total { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }

        public Cart()
        {
            CartItems = new List<CartItem>();
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
