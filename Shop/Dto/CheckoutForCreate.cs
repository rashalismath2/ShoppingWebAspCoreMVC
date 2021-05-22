using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Dto
{
    public class CheckoutForCreate
    {
        public int UserId { get; set; }
        public string CartId { get; set; }
        [Required, MinLength(4)]
        public string FullName { get; set; }
        [Required, MinLength(10)]
        public string Phone { get; set; }
        [Required, MinLength(8)]
        public string Address { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public City City { get; set; }
        public string Note { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime Date { get; set; }
    }
}
