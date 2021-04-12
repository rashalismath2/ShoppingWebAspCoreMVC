
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
        public async Task<IActionResult> AddToCart(ProductCartViewModel productCartViewModel)
        {

            Cart newCart = await CartRepository.GetCart();
            productCartViewModel.CartItem.ProductId = productCartViewModel.Product.ProductId;

            List<CartItem> cartItems = newCart.CartItems
                .Where(
                        ci => ci.Product.ProductId == productCartViewModel.Product.ProductId).ToList();

            //calculating qty will be determined by only the product id, size wont be included
            //total of the qty exist in the cart and we are adding should be less than 10
            int qtyTotal=cartItems.Sum(s => s.Qty);

            if (qtyTotal + productCartViewModel.CartItem.Qty > 10)
            {
                TempData["ProductErrorMessage"] = "You can only add 10 items per product. You have already added " + qtyTotal + " items.";

                return RedirectToAction("Details", new { id = productCartViewModel.Product.ProductId });
            }


            //if we have a product with same size in the cart items we just simply add two quentities
            bool foundProduct = false;
            foreach (var item in cartItems)
            {
                if (item.Size==productCartViewModel.CartItem.Size) {
                    foundProduct = true;
                    item.Qty += productCartViewModel.CartItem.Qty;
                }
            }
            //if we didnt found a product with the same size but different size we will add it to the cart
            if (!foundProduct) {
                newCart.CartItems.Add(productCartViewModel.CartItem);
            }
           
            CartRepository.Update(newCart);

            TempData["ProductSuccessMessage"] = "Product added to the cart";

            return RedirectToAction("Details", new { id = productCartViewModel.Product.ProductId });
        }
    }
}
