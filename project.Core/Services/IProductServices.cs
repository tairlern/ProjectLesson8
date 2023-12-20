using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface IProductServices
    {
        List<Product> GetAll(string? text = "");
        Product Get(int id);
        void Delete(int id);
        void Put(int id, Product cust);
        void Post(Product cust);
    }
}
