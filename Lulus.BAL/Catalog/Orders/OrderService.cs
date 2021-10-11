﻿using Lulus.BAL.Catalog.Orders.Interfaces;
using Lulus.Data.EF;
using Lulus.ViewModels.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Orders
{
    public class OrderService: IOrderService
    {
        private readonly LulusDBContext _context;
        public OrderService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<int> AddProductAsync(AddProductToCartRequest request)
        {
            // Invalid 1: User not found
            if (!(await UserIDValid(request.UserID))) return 1;
            // Invalid 2: Order not found
            var order = await _context.Orders.Where(x => x.Order_ID == request.OrderID).FirstOrDefaultAsync();
            if (order == null) return 2;
            // Invalid 3: Product line not found
            var line = await _context.ProductLines.Where(x => x.ProductLine_ID == request.ProductLineID).FirstOrDefaultAsync();
            if (line == null) return 3;
            // Invalid 4: Size not found
            var size = await _context.Sizes.Where(x => x.Size_ID == request.SizeID).FirstOrDefaultAsync();
            if (size == null) return 4;
            var quantity = await _context.LineQuantities.Where(x => x.ProductLine_ID == request.ProductLineID && x.Size_ID == request.SizeID).Select(x => x.Quantity).FirstOrDefaultAsync();
            var checkExist = await _context.OrderDetails.Where(x => x.Order_ID == request.OrderID && x.ProductLine_ID == request.ProductLineID &&x.Size_ID == request.SizeID).FirstOrDefaultAsync();
            if(checkExist != null)
            {
                // Invalid 5: Dont have enough product quantity
                if (checkExist.OrderDetail_Quantity + request.Quantity >= quantity) return 5;
                checkExist.OrderDetail_Quantity += request.Quantity;
                await _context.SaveChangesAsync();
                // Valid 6: Update quantity success
                return 6;
            }
            else
            {
                if (request.Quantity >= quantity) return 5;
                var price = await _context.Products.Where(x => x.Product_ID == line.Product_ID).Select(x => x.Product_SalePrice).FirstOrDefaultAsync();
                _context.OrderDetails.Add(new Data.Entities.OrderDetail()
                {
                    OrderDetail_Quantity = request.Quantity,
                    Order_ID = request.OrderID,
                    ProductLine_ID = request.ProductLineID,
                    Size_ID = request.SizeID,
                    OrderDetail_Total = price * request.Quantity
                });
                await _context.SaveChangesAsync();
                // Valid 7: Add product line success
                return 7;
            }
        }

        public Task<bool> ChangeQuantityAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ClearCartAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetCheckoutInforAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CurrentCartRespond> GetCurrentOrderAsync(Guid userID)
        {
            if(!(await UserIDValid(userID)))
            {
                return null;
            }
            var order = await _context.Orders.Where(x => x.User_ID == userID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync();
            if(order == null)
            {
                var createdOrder = new Data.Entities.Order()
                {
                    CreatedDate = DateTime.Now,
                    Order_Total = 0,
                    User_ID = userID,
                    Status = Data.Enums.OrderStatus.Choosing
                };
                _context.Orders.Add(createdOrder);
                await _context.SaveChangesAsync();
                return new CurrentCartRespond()
                {
                    Order_ID = (await _context.Orders.Where(x => x.User_ID == userID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync()).Order_ID,
                    Order_Total = 0,
                    Status = Data.Enums.OrderStatus.Choosing,
                    DetailCount = 0,
                    OrderDetails = new List<OrderDetailInCart>()
                };
            }
            else
            {
                order.OrderDetails = await _context.OrderDetails.Where(x => x.Order_ID == order.Order_ID).ToListAsync();
                var respondOrder = new CurrentCartRespond()
                {
                    Order_ID = order.Order_ID,
                    Order_Total = order.OrderDetails.Sum(x => x.OrderDetail_Total),
                    Status = Data.Enums.OrderStatus.Choosing,
                    DetailCount = order.OrderDetails.Count,
                    OrderDetails = new List<OrderDetailInCart>()
                };
                foreach(var item in order.OrderDetails)
                {
                    var line = await _context.ProductLines.Where(x => x.ProductLine_ID == item.ProductLine_ID).Select(x => x.ProductLine_ID).FirstOrDefaultAsync();
                    var product = await _context.Products.Where(x => x.Product_ID == line).FirstOrDefaultAsync();
                    var image = await _context.ProductImages.Where(x => x.ProductLine_ID == item.ProductLine_ID).Select(x => x.ProductImage_Image).FirstAsync();
                    var sizeKey = await _context.Sizes.Where(x => x.Size_ID == item.Size_ID).Select(x => x.Size_Key).FirstAsync();
                    respondOrder.OrderDetails.Add(new OrderDetailInCart()
                    {
                        OrderDetail_ID = item.OrderDetail_ID,
                        OrderDetail_Quantity = item.OrderDetail_Quantity,
                        Product_Name = product.Product_Name,
                        Product_Image = image,
                        Product_Price = product.Product_Price,
                        Product_SellPrice = product.Product_SalePrice,
                        Status = product.Status,
                        SizeKey = sizeKey,
                        OrderDetail_Total = item.OrderDetail_Quantity * product.Product_SalePrice
                    });
                }
                return respondOrder;
            }
        }

        public Task<bool> RemoveProductAsync()
        {
            throw new NotImplementedException();
        }
        private async Task<bool> UserIDValid(Guid userID)
        {
            var user = await _context.Users.Where(x => x.Id == userID).FirstOrDefaultAsync();
            if (user == null) return false;
            return true;
        }
    }
}
