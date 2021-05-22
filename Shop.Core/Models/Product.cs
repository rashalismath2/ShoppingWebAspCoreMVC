using Shop.Core.Models.Enums;
using Shop.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class Product
    {
        private static Currencies Currency = Currencies.LKR;
        public int ProductId { get; set; }
        [Required, MinLength(2)]
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        [Required]
        public ProductType Type { get; set; }
        public float DiscountPrecentage { get; set; }
        [Required]
        public float Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string GetPrice
        {
            get
            {
                return StringManipulation.GetPriceString(Price, Currency);
            }
        }

    }
}
