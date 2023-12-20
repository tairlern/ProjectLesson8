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
            return _context.CustomerList;
        }
    }
}
