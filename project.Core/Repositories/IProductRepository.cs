using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product Get(int id);
        void Delete(int id);
        Product Put(int id, Product cust);
        Product Post(Product cust);
    }
}
