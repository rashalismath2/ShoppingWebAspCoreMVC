using Shop.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class User
    {
        public User()
        {
            Checkouts = new List<Checkout>();
        }
        public int UserId { get; set; }
        [Required,MinLength(3)]
        public string FirstName { get; set; }
        [Required, MinLength(3)]
        public string LastName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(3)]
        public string Address { get; set; }
        [Required, MinLength(10)]
        public string ContactNumber { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
        public List<Checkout> Checkouts { get; set; }
        public string FullName
        {
            get{ return StringManipulation.GetFullName(FirstName, LastName); }
        }

    }
}
