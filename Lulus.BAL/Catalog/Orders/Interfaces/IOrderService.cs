using Lulus.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Orders.Interfaces
{
    public interface IOrderService
    {
        Task<CurrentCartRespond> GetCurrentOrderAsync(Guid userID);
        Task<int> AddProductAsync(AddProductToCartRequest request);
        Task<bool> RemoveProductAsync(int orderDetailID);
        Task<bool> ClearCartAsync(int orderID);
        Task<bool> ChangeQuantityAsync(ChangeQuantityRequest request);
        Task<CurrentCartRespond> GetCheckoutInforAsync(int orderID);
        Task<bool> CheckoutAsync(int orderID);
    }
}
