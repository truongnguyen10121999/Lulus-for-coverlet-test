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
        public IActionResult AddProductFailed()
        {
            return View();
        }
        public IActionResult AddProductSuccess()
        {
            return View();
        }
    }
}
