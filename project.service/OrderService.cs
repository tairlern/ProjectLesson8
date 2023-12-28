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
    public class OrderService : IOrderServices
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository userRepository)
        {
            _OrderRepository = userRepository;
        }

        public List<Order> GetAll(string? text = "")
        {
            
            return _OrderRepository.GetList().Where(u => u.Name.Contains(text)).ToList();

        }
        public Order Get(int id)
        {
            return _OrderRepository.Get(id);
        }
        public void Delete(int id)
        {
                _OrderRepository.Delete(id);
        }
        public Order Put(int id, Order ordr) {
           return _OrderRepository.Put(id, ordr);
        }
        public Order Post(Order ordr)
        {
            return _OrderRepository.Post(ordr);
        }
    }
}
