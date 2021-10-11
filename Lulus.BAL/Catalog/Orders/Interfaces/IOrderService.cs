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
        Task<bool> RemoveProductAsync();
        Task<bool> ClearCartAsync();
        Task<bool> ChangeQuantityAsync();
        Task<bool> GetCheckoutInforAsync();
        Task<bool> CheckoutAsync();
    }
}
