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
        Customer Put(int id, Customer cust);
        Customer Post(Customer cust);
    }
}
