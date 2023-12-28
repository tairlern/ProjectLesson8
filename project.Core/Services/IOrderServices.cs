using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface IOrderServices
    {
        List<Order> GetAll(string? text = "");
        Order Get(int id);
        void Delete(int id);
        Order Put(int id, Order cust);
        Order Post(Order cust);
    }
}
