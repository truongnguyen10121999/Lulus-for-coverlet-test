using Lulus.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Order
{
    public class OrderDetailInCart
    {
        public int OrderDetail_ID { get; set; }

        public int OrderDetail_Quantity { get; set; }

        public double OrderDetail_Total { get; set; }
        public string Product_Name { get; set; }
        public string Product_Image { get; set; }
        public double Product_Price { get; set; }
        public double Product_SellPrice { get; set; }
        public ProductStatus Status { get; set; }
        public string SizeKey { get; set; }
    }
}
