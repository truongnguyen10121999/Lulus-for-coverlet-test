using Lulus.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Orders
{
    public class OrderService
    {
        private readonly LulusDBContext _context;
        public OrderService(LulusDBContext context)
        {
            _context = context;
        }
    }
}
