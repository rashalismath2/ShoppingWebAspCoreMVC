using AutoMapper;
using Shop.Core.Models;
using Shop.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Profiles
{
    public class CheckoutProfile:Profile
    {
        public CheckoutProfile()
        {
            CreateMap<CheckoutForCreate, Checkout>();
            CreateMap<Checkout, CheckoutForCreate>();
        }
    }
}
