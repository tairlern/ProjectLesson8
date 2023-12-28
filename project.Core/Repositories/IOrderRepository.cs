using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetList();
        Order Get(int id);
        void Delete(int id);
        void Put(int id, Order cust);
        void Post(Order cust);
    }
}
