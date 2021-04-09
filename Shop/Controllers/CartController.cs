using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repository.RepositoryInterfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        public CartController(ICartRepository CartRepository)
        {
            this.CartRepository = CartRepository;
        }

        public ICartRepository CartRepository { get; }

        public async Task<IActionResult> Index()
        {
            Cart cart =await CartRepository.GetCart();
            var cartItemsGroupedBy = cart.CartItems.GroupBy(ci => ci.ProductId);

            List<CartDetails> cartItems = new List<CartDetails>();

            foreach (var item in cartItemsGroupedBy)
            {
                CartDetails cartItem = new CartDetails(item.ToList());
                cartItems.Add(cartItem);
            }

            CartDetailsViewModel detailsViewModel = new CartDetailsViewModel(cart,cartItems);
            

            return View(detailsViewModel);
        }
    }
}
