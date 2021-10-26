using Lulus.CustomerApp.Services.Interfaces;
using Lulus.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IOrderApi _orderApi;
        public CartController(IOrderApi orderApi)
        {
            _orderApi = orderApi;
        }
        public async Task<IActionResult> Index()
        {
            var currentCart = await _orderApi.GetCurrentCart(new Guid(HttpContext.User.Claims.First().Value));
            return View(currentCart);
        }
        public async Task<IActionResult> AddProduct(string id)
        {
            string[] t = id.Split(",");
            var request = new AddProductToCartRequest
            {
                UserID = new Guid(HttpContext.User.Claims.First().Value),
                ProductLineID = int.Parse(t[0]),
                SizeID = int.Parse(t[1]),
                Quantity = int.Parse(t[2])
            };
            if (request.Quantity == 0) return RedirectToAction("AddProductFailed");
            var result = await _orderApi.AddProduct(request);
            if(result == "") return RedirectToAction("AddProductFailed");
            return RedirectToAction("AddProductSuccess");
        }
        public async Task<IActionResult> ClearCart(int orderID)
        {
            var result = await _orderApi.Clear(orderID);
            return RedirectToAction("Index");
        }
        public IActionResult AddProductFailed()
        {
            return View();
        }
        public IActionResult AddProductSuccess()
        {
            return View();
        }
        public async Task<IActionResult> RemoveProduct(int orderDetailID)
        {
            var result = await _orderApi.RemoveProduct(orderDetailID);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int Id, int Quantity)
        {
            var request = new ChangeQuantityRequest()
            {
                OrderDetailID = Id,
                Quantity = Quantity
            };
            var result = await _orderApi.ChangeQuantity(request);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Checkout(int id)
        {
            var result = await _orderApi.CheckoutInfo(id);
            return View(result);
        }
        public async Task<IActionResult> Confirmation(int id)
        {
            var result = await _orderApi.Checkout(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Orders()
        {
            var orders = await _orderApi.GetOrders(new Guid(HttpContext.User.Claims.First().Value));
            return View(orders);
        }
    }
}
