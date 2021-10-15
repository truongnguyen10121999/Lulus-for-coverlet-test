using Lulus.BackendApi.Infrastructures;
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
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        private readonly ICurrentUser _currentUser;
        public OrderController(IOrderService service, ICurrentUser currentUser)
        {
            _service = service;
            _currentUser = currentUser;
        }
        [HttpGet]
        public async Task<IActionResult> GetCurrentCart()
        {
            var result = await _service.GetCurrentOrderAsync(_currentUser.UserId);
            if(result == null)
            {
                return BadRequest("User not found");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductToCartRequest request)
        {
            var requestAlter = new AddProductToCartRequest()
            {
                UserID = _currentUser.UserId,
                ProductLineID = request.ProductLineID,
                SizeID = request.SizeID,
                Quantity = request.Quantity
            };
            //request.UserID = _currentUser.UserId;
            var result = await _service.AddProductAsync(requestAlter);
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
    }
}
