using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{

    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public ProductType Type { get; set; }
        public float DiscountPrecentage { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string GetPrice { get {
                return "LKR."+Price;
            }  }

    }
}
