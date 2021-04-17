using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public List<Checkout> Checkouts { get; set; }
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
