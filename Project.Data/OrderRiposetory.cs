using Project.Core.Models;
using Project.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class OrderRiposetory : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRiposetory(DataContext context)
        {
            _context = context;
        }

        public List<Order> GetList()
        {
            return _context.OrderList;
        }
    }
}
