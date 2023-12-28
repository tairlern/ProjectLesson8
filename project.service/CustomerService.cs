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
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository userRepository)
        {
            _CustomerRepository = userRepository;
        }

        public List<Customer> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _CustomerRepository.GetList();
        }
        public Customer Get(int id)
        {
            return _CustomerRepository.Get(id);
        }
        public void Delete(int id)
        {
            _CustomerRepository.Delete(id);
           
        }

        public void Put(int id, Customer cust)
        {
            _CustomerRepository.Put(id, cust);
        }
        public void Post(Customer cust)
        {
            _CustomerRepository.Post(cust);
        }

    }
}
