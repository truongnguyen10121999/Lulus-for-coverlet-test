using Lulus.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Order
{
    public class OrderRespond
    {
        public int Order_ID { get; set; }

        public double Order_Total { get; set; }

        public OrderStatus Status { get; set; }
        public int DetailCount { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
