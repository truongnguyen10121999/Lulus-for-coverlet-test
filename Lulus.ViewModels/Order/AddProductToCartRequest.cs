using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Order
{
    public class AddProductToCartRequest
    {
        public Guid UserID { get; set; }
        public int ProductLineID { get; set; }
        public int Quantity { get; set; }
        public int SizeID { get; set; }
    }
}
