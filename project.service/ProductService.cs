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
            //לוגיקה עסקית
            return _ProductRepository.GetList().Where(u => u.Name.Contains(text)).ToList();
        }
        public  Product Get(int id) {

           return _ProductRepository.GetList().Find(p => p.Id == id);
        }
        public  void Delete(int id) {
            _ProductRepository.GetList().Remove(_ProductRepository.GetList().Find(p => p.Id == id));
        }
        public  void Put(int id, Product prod) {
            _ProductRepository.GetList(). Find(p => p.Id == id).Id = prod.Id;
            _ProductRepository.GetList().Find(p => p.Id == id).Name = prod.Name;
        }
        public  void Post(Product prod) {
            _ProductRepository.GetList().Add(prod);
        }
    }
}

