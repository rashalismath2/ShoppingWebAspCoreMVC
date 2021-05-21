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

        private ICartRepository _cartRepository { get; }
        private ICheckoutRepository _checkoutRepository { get; }
        private ICartService _cartService { get; }
        private IAuthService _authService { get; }

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
            string cartId = _cartService.GetCartIdFromSession();
            Cart cart = await _cartRepository.GetCart(cartId);

            var emptyCartValue = 1;

            if (cart.CartItems.Count < emptyCartValue)
            {
                TempData["ErrorMessage"] = "The cart is empty";
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            User user = await _authService.GetAuthUser();

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

        [HttpPost]
        public async Task<IActionResult> Index(Checkout checkout)
        {

            string cartIdFromSession = _cartService.GetCartIdFromSession();
            Cart cart = await _cartRepository.GetCart(cartIdFromSession);

            if (ModelState.IsValid)
            {
                //TODO- ACID. Cart and Checkout saved seprately
                var authUser= await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name);
                checkout.UserId = authUser.UserId;

                checkout.Date = DateTime.Now;
                await _checkoutRepository.Create(checkout);

                cart = _cartService.ProcessCart(cart);

                await _cartRepository.Update(cart);

                _cartService.ClearCartFromSession();

                TempData["SuccessMessage"] = "Checkout complete";

                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }


            checkout.Cart = cart;

            return View(checkout);
        }

        public async Task<IActionResult> History(int? pageNumber) {

            ViewBag.PageNumber = pageNumber;
            var totalCheckoutResultCount = await _checkoutRepository.CheckoutLength();
            var resultsPerPage = ICheckoutService.ResultsPerPage;
            var checkoutPagesCount = (int)Math.Ceiling((double)(totalCheckoutResultCount / resultsPerPage));
            ViewBag.CheckoutCounts = checkoutPagesCount;

            var authUser = await _userRepository.GetUserByEmail(HttpContext.User.Identity.Name);
            var checkouts = await _checkoutRepository.RetrieveResultForPage(authUser.UserId,pageNumber,resultsPerPage);
            return View(checkouts);
        }
    }
}
