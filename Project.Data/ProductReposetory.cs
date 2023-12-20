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
            return _context.ProductList;
        }
    }
}
