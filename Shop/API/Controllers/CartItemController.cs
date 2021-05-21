using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/cartitem")]
    [Authorize]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        public CartItemController(ICartItemRepository cartItempRepository)
        {
            this._cartItempRepository = cartItempRepository;
        }

        public ICartItemRepository _cartItempRepository { get; }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            try
            {
                CartItem cartItem = await _cartItempRepository.DeleteById(id);

                if (cartItem != null)
                {
                    return NoContent();
                }

                return NotFound();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
