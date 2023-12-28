using Project.Core.Models;
using Project.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class CustomerReposetory: ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerReposetory (DataContext context)
        {
            _context = context;
        }

        public List<Customer> GetList()
        {
            return _context.CustomerList.ToList();
        }
         public Customer Get(int id)
        {
            return _context.CustomerList.ToList().Find(c => c.Id == id);
        }
        public void Delete(int id)
        {

            _context.CustomerList.ToList().Remove(_context.CustomerList.ToList().Find(c => c.Id == id));
        }

        public void Put(int id, Customer cust)
        {
            _context.CustomerList.ToList().Find(c => c.Id == id).Id = cust.Id;
            _context.CustomerList.ToList().Find(c => c.Id == id).Name = cust.Name;
        }
        public void Post(Customer cust)
        {
            _context.CustomerList.ToList().Add(cust);
        }
    }
}
