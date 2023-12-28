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
            return _context.OrderList.ToList();
        }
        public Order Get(int id)
        {
            return _context.OrderList.ToList().Find(o => o.Id == id);
        }
        public void Delete(int id)
        {
            _context.OrderList.ToList().Remove(_context.OrderList.ToList().Find(o => o.Id == id));
        }
        public void Put(int id, Order ordr)
        {
            _context.OrderList.ToList().Find(o => o.Id == id).Id = ordr.Id;
            _context.OrderList.ToList().Find(o => o.Id == id).Product = ordr.Product;
            _context.OrderList.ToList().Find(o => o.Id == id).CountProdact = ordr.CountProdact;
            _context.OrderList.ToList().Find(o => o.Id == id).DateOrder = ordr.DateOrder;
        }
        public void Post(Order ordr)
        {
            _context.OrderList.ToList().Add(ordr);
        }
    }
}
