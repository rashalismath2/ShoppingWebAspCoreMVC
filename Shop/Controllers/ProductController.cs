
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Models.Enums;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductRepository _productsRepository;
        private readonly ICartRepository _cartRepository;
        private readonly ICartService _cartService;

        public ProductController(
            IProductRepository products,
            ICartRepository cartRepository,
            ICartService cartService,
            IProductService productService
         )
        {
            _productsRepository = products;
            _cartRepository = cartRepository;
            _cartService = cartService;
            _productService = productService;
        }

        public async Task<IActionResult> Category(ProductType category, string priceFilterByCat, int? pageNumber)
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.ProductType = category;
            ViewBag.ProductByCategoryListCount = (int)Math.Ceiling((double)_productsRepository.ProductByCategoryLength(category) / IProductService.ProductsPerPage);

            try
            {
                List<Product> products =await _productsRepository.ByCatergory(
                                        category, priceFilterByCat,
                                        pageNumber,
                                        IProductService.ProductsPerPage
                                );

                return View(products);
            }
            catch (Exception)
            {
                return RedirectToHomeOnExceptions("Something went wrong! Try again");
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            Product product = null;
            string cartId = null;
            try
            {
                cartId = _cartService.GetCartId();
                product =await _productsRepository.GetById(id);
            }
            catch (Exception)
            {
                return RedirectToHomeOnExceptions("Something went wrong! Try again");
            }

            if (product == null)
            {
                TempData["CustomErrorTitle"] = "404";
                TempData["CustomErrorMessage"] = "Product was not found";
                return RedirectToRoute(new { controller = "Home", action = "Error" });
            }

            ProductCartViewModel productCartViewModel = new ProductCartViewModel() {
                Product = product,
                CartItem = new CartItem() { CartId = cartId }
            };

            return View(productCartViewModel);
        }

        private IActionResult RedirectToHomeOnExceptions(string error)
        {
            TempData["ErrorMessage"] = error;
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        /// <summary>
        /// Delete this method. moved to the API
        /// </summary>
        /// <param name="productCartViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddToCart(ProductCartViewModel productCartViewModel)
        {
            string cartId = _cartService.GetCartId();
            Cart newCart = await _cartRepository.GetCart(cartId);
            productCartViewModel.CartItem.ProductId = productCartViewModel.Product.ProductId;

            List<CartItem> cartItems = newCart.CartItems
                .Where(ci => ci.Product.ProductId == productCartViewModel.Product.ProductId)
                .ToList();

            //calculating qty will be determined by only the product id, size wont be included
            //total of the qty exist in the cart and we are adding should be less than 10
            int qtyTotal = cartItems.Sum(s => s.Qty);
            int totalItemsToBeAdded = qtyTotal + productCartViewModel.CartItem.Qty;
            int allowedItemsToBeAdded = 10;

            if (totalItemsToBeAdded > allowedItemsToBeAdded)
            {
                TempData["ProductErrorMessage"] = @"You can only add 10 items per product. You have already added "
                                                     + qtyTotal + " items.";

                return RedirectToAction("Details", new { id = productCartViewModel.Product.ProductId });
            }


            //if we have a product with same size in the cart items we just simply add two quentities
            bool foundProductWithSameSize = false;
            foreach (var item in cartItems)
            {
                if (item.Size == productCartViewModel.CartItem.Size)
                {
                    foundProductWithSameSize = true;
                    item.Qty += productCartViewModel.CartItem.Qty;
                }
            }
            //if we didnt found a product with the same size but different size we will add it to the cart
            if (!foundProductWithSameSize)
            {
                newCart.CartItems.Add(productCartViewModel.CartItem);
            }

            try
            {
                await _cartRepository.Update(newCart);

                TempData["ProductSuccessMessage"] = "Product was added to the cart";

                return RedirectToAction("Details", new { id = productCartViewModel.Product.ProductId });
            }
            catch (Exception)
            {
                TempData["ProductErrorMessage"] = "Product was unable to add to the cart";
                return RedirectToAction("Details", new { id = productCartViewModel.Product.ProductId });
            }

        }

    }
}
