using Lulus.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Services.Interfaces
{
    public interface IOrderApi
    {
        Task<CurrentCartRespond> GetCurrentCart();
        Task<string> AddProduct(AddProductToCartRequest request);
    }
}
