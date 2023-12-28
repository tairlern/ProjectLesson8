using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetList();
        Customer Get(int id);
        void Delete(int id);
        void Put(int id, Customer cust);
        void Post(Customer cust);
    }
}
