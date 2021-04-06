﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; private set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}
