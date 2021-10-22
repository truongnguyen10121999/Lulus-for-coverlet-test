using Lulus.BAL.Catalog.Orders.Interfaces;
using Lulus.ViewModels.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurrentCart(Guid id)
        {
            var result = await _service.GetCurrentOrderAsync(id);
            if(result == null)
            {
                return BadRequest("User not found");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductToCartRequest request)
        {

            //request.UserID = _currentUser.UserId;
            var result = await _service.AddProductAsync(request);
            switch (result)
            {
                case 1: return BadRequest("User not found");
                case 2: return BadRequest("Order not found");
                case 3: return BadRequest("Product line not found");
                case 4: return BadRequest("Size not found");
                case 5: return BadRequest("Dont have enough product quantity");
                case 6: return Ok("Update quantity success");
                case 7: return Ok("Add product line success");
                default: return BadRequest("Something was wrong");
            }
        }
        [HttpPost]
        public async Task<IActionResult> RemoveProduct(int orderDetailID)
        {
            var result = await _service.RemoveProductAsync(orderDetailID);
            if (result == false) return BadRequest();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> ClearCart(int orderID)
        {
            var result = await _service.ClearCartAsync(orderID);
            if (result == false) return BadRequest();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(ChangeQuantityRequest request)
        {
            var result = await _service.ChangeQuantityAsync(request);
            if (result == false) return BadRequest();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> CheckoutInfo(int id)
        {
            var result = await _service.GetCheckoutInforAsync(id);
            if (result == null) return BadRequest();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(int orderID)
        {
            var result = await _service.CheckoutAsync(orderID);
            if (result == false) return BadRequest();
            return Ok();
        }
    }
}
