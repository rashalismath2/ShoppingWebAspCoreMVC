﻿using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ProductSize Size { get; set; }
        public ProductColor Color { get; set; }
        public Cart Cart { get; set; }
        public string CartId { get; set; }
        public int Qty { get; set; }

        public float Total { get; private set; }
        public float SubTotal { get; private set; }
        public float Discount { get; private set; }

        public float GetTotal() {

            if (Product != null)
            {
                float sub = GetSubTotal();
                if (sub>0) {
                    return sub - GetDiscount();
                }
                return 0;
            }
            return 0;
        }
        public float GetSubTotal()
        {
            if (Product != null)
            {
                return (Product.Price * Qty);
            }
            return 0;
        }
        public float GetDiscount()
        {
            if (Product != null)
            {
                return Product.DiscountPrecentage * Product.Price * Qty / 100;
            }
            return 0;
        }
        


    }
}
