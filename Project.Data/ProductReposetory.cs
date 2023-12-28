using Project.Core.Models;
using Project.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class ProductReposetory: IProductRepository
    {
        private readonly DataContext _context;

        public ProductReposetory(DataContext context)
        {
            _context = context;
        }

        public List<Product> GetList()
        {
            return _context.ProductList.ToList();
        }
        public Product Get(int id)
        {

            return _context.ProductList.ToList().Find(p => p.Id == id);
        }
        public void Delete(int id)
        {
            _context.ProductList.ToList().Remove(_context.ProductList.ToList().Find(p => p.Id == id));
        }
        public void Put(int id, Product prod)
        {
            _context.ProductList.ToList().Find(p => p.Id == id).Id = prod.Id;
            _context.ProductList.ToList().Find(p => p.Id == id).Name = prod.Name;
        }
        public void Post(Product prod)
        {
            _context.ProductList.ToList().Add(prod);
        }
    }
}
