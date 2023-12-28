using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class ProductService: IProductServices
    {
        
        private readonly IProductRepository _ProductRepository;

        public ProductService(IProductRepository userRepository)
        {
            _ProductRepository = userRepository;
        }

        public List<Product> GetAll(string? text = "")
        {
           
            return _ProductRepository.GetList().Where(u => u.Name.Contains(text)).ToList();
        }
        public  Product Get(int id) {

           return _ProductRepository.Get(id);
        }
        public  void Delete(int id) {
            _ProductRepository.Delete(id);
        }
        public  Product Put(int id, Product prod) {
           return _ProductRepository.Put(id, prod);
        }
        public  Product Post(Product prod) {
            return _ProductRepository.Post(prod); 
        }
    }
}

