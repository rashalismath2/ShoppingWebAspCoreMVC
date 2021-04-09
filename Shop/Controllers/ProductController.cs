
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
    public class ProductController : Controller
    {
        public ProductController(IProductRepository products, ICartRepository cartRepository)
        {
            Products = products;
            CartRepository = cartRepository;
        }
    
        public IProductRepository Products { get; }
        public ICartRepository CartRepository { get; }

        public IActionResult Index()
        {
            return View("NotFound");
        }

        public IActionResult Details(int id)
        {
            Product product = Products.GetById(id);
            if (product == null)
            {
                return View("NotFound");
            }
            ProductCartViewModel productCartViewModel = new ProductCartViewModel();
            productCartViewModel.Product = product;
            productCartViewModel.CartItem = new CartItem(); ;
            return View(productCartViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(ProductCartViewModel productCartViewModel) {

            Cart newCart =await CartRepository.GetCart();
            productCartViewModel.CartItem.ProductId = productCartViewModel.Product.ProductId;

            int qtyTotal = newCart.CartItems
                .Where(ci => ci.Product.ProductId == productCartViewModel.Product.ProductId)
                .Sum(s=>s.Qty);
          
            if (qtyTotal+productCartViewModel.CartItem.Qty > 10)
            {
                TempData["ErrorMessage"] = "You can only add 10 items per product. You hace already added "+qtyTotal+" items.";

                return RedirectToAction("Details", new { id = productCartViewModel.Product.ProductId });
            }

            newCart.CartItems.Add(productCartViewModel.CartItem);
            
            CartRepository.Update(newCart);

            TempData["SuccessMessage"] = "Product added to the cart";
            
            return RedirectToAction("Details",new {id=productCartViewModel.Product.ProductId });
        }
    }
}
