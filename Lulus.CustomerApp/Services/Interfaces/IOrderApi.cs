using Lulus.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Services.Interfaces
{
    interface IOrderApi
    {
        Task<CurrentCartRespond> GetCurrentCart(Guid userID);
        Task<string> AddProduct(AddProductToCartRequest request);
    }
}
