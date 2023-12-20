
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class DataContext
    {
        public List<Customer> CustomerList { get; set; }

        public List<Order> OrderList { get; set; }
        public List<Product> ProductList { get; set; }

        public DataContext()
        {
            CustomerList = new List<Customer> { new Customer { Id = 1, Name = "name",  } };
            OrderList= new List<Order> { new Order { IdOrder = 1, CountProdact = 3 , } };
            ProductList = new List<Product> { new Product { Id = 1, Name = "name", } };
        }
    }
}
