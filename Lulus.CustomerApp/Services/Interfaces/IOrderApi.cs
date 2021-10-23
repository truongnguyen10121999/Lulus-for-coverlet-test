using Lulus.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Services.Interfaces
{
    public interface IOrderApi
    {
        Task<CurrentCartRespond> GetCurrentCart(Guid userID);
        Task<string> AddProduct(AddProductToCartRequest request);
        Task<bool> RemoveProduct(int orderDetailID);
        Task<bool> Clear(int orderID);
        Task<bool> ChangeQuantity(ChangeQuantityRequest request);
        Task<bool> Checkout(int orderID);
        Task<CurrentCartRespond> CheckoutInfo(int id);
        Task<List<OrderRespond>> GetOrders(Guid userID);
    }
}
