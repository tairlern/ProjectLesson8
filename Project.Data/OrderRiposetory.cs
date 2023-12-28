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
            return _context.OrderList.Find( id);
        }
        public void Delete(int id)
        {
            var o=Get(id);
            _context.OrderList.Remove(o);
        }
        public Order Put(int id, Order ordr)
        {
            var o=Get(id);
            o.Id = ordr.Id;
           o.Product= ordr.Product;
            o.CountProdact = ordr.CountProdact;
           o.DateOrder = ordr.DateOrder;
            return ordr;
        }
        public Order Post(Order ordr)
        {
            _context.OrderList.Add(ordr);
            return ordr;
        }
    }
}
