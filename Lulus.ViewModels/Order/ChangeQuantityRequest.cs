using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.Order
{
    public class ChangeQuantityRequest
    {
        public int OrderDetailID { get; set; }
        public int Quantity { get; set; }
    }
}
