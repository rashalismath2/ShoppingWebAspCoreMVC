using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using Shop.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ICartRepository _cartRepository;
        private readonly ICheckoutRepository _checkoutRepository;
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;

        public CheckoutController(
                ICartRepository cartRepository,
                ICheckoutRepository checkoutRepository,
                ICartService cartService,
                IAuthService authService,
                IUserRepository userRepository
            )
        {
            this._cartRepository = cartRepository;
            this._checkoutRepository = checkoutRepository;
            this._cartService = cartService;
            this._authService = authService;
            this._userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string cartId = _cartService.GetCartId();
            Cart cart=null;
            try
            {
                cart = await _cartRepository.GetCart(cartId);
            }
            catch (Exception)
            {
                return this.RedirectToHomeOnExceptions("Something went wrong!");
            }

            if (cart.CartItems.Count < 1)
            {
                return this.RedirectToHomeOnExceptions("The cart is empty");
            }

            User user=null;
            try
            {
                user = await _authService.GetAuthUser();
            }
            catch (Exception)
            {
                return this.RedirectToHomeOnExceptions("Something went wrong!");
            }

            Checkout checkout = new Checkout()
            {
                Cart = cart,
                UserId = user.UserId,
                FullName = user.FullName,
                Address = user.Address,
                Email = user.Email,
                Phone = user.ContactNumber
            };

            return View(checkout);
        }


        public async Task<IActionResult> History(int? pageNumber)
        {

            ViewBag.PageNumber = pageNumber;
            var totalCheckoutResultCount = await _checkoutRepository.CheckoutLength();
            var resultsPerPage = ICheckoutService.ResultsPerPage;
            var checkoutPagesCount = (int)Math.Ceiling((double)(totalCheckoutResultCount / resultsPerPage));
            ViewBag.CheckoutCounts = checkoutPagesCount;

            var authUser = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name);
            var checkouts = await _checkoutRepository.RetrieveResultForPage(authUser.UserId, pageNumber, resultsPerPage);
            return View(checkouts);
        }

        private IActionResult RedirectToHomeOnExceptions(string error)
        {
            TempData["ErrorMessage"] = error;
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        /// <summary>
        /// Delete this method since we use the API controller
        /// </summary>
        /// <param name="checkout"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Index(Checkout checkout)
        {
            Cart cart = null;
            try
            {
                string cartId = _cartService.GetCartId();
                cart = await _cartRepository.GetCart(cartId);
            }
            catch (Exception)
            {
                return this.RedirectToHomeOnExceptions("Something went wrong! Try again");
            }

            checkout.Cart = cart;
            if (!ModelState.IsValid)
            {
                return View(checkout);
            }

            try
            {
                //TODO- ACID. Cart and Checkout saved seprately
                var authUser = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name);
                checkout.UserId = authUser.UserId;
                checkout.Date = DateTime.Now;

                await _checkoutRepository.Create(checkout);
                cart = _cartService.ProcessCart(cart);
                await _cartRepository.Update(cart);
            }
            catch (Exception)
            {
                return this.RedirectToHomeOnExceptions("Something went wrong! Try again");
            }

            _cartService.ClearCart();
            TempData["SuccessMessage"] = "Checkout complete";

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

    }
}
