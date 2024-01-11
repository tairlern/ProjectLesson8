using Microsoft.EntityFrameworkCore;
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
            return _context.ProductList.Include(p=>p.Orders).ToList();
        }
        public Product Get(int id)
        {

            return _context.ProductList.ToList().Find(p => p.Id == id);
        }
        public void Delete(int id)
        {
            var o = Get(id);
            _context.ProductList.Remove(o);
            //_context.SaveChanges();
        }
        public Product Put(int id, Product prod)
        {
        var o=Get(id);
           o.Id = prod.Id;
           o.Name = prod.Name;
            return prod;
        }
        public Product Post(Product prod)
        {
            _context.ProductList.Add(prod);
            //_context.SaveChanges();
            return prod;
        }
    }
}
