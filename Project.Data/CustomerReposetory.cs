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
            return _context.CustomerList.Find(id);
        }
        public void Delete(int id)
        {
            var c=Get(id);
            _context.CustomerList.Remove(c);
            _context.SaveChanges();
        }

        public Customer Put(int id, Customer cust)
        {
            var c = Get(id);
           c.Id = cust.Id;
            c .Name = cust.Name;
            _context.SaveChanges();
            return c;
        }
        public Customer Post(Customer cust)
        {
            _context.CustomerList.Add(cust);
            _context.SaveChanges();
            return cust;
        }
       
    }
}
