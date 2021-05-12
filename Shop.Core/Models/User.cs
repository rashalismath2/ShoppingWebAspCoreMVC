using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class User
    {
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
        public List<Checkout> Checkouts { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                {
                    if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                    {
                        return "";
                    }
                    if (string.IsNullOrWhiteSpace(LastName))
                    {
                        return FirstName.Trim();
                    }
                    if (string.IsNullOrWhiteSpace(FirstName))
                    {
                        return LastName.Trim();
                    }
                }

                return FirstName.Trim() + " " + LastName.Trim();
            }


        }

    }
}
