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
            return _CustomerRepository.GetList().Where(u => u.Name.Contains(text)).ToList();
        }
        public Customer Get(int id)
        {
            return _CustomerRepository?.GetList().Find(c => c.Id == id);
        }
        public void Delete(int id)
        {

            _CustomerRepository?.GetList().Remove(_CustomerRepository.GetList()?.Find(c => c.Id == id));
        }

        public void Put(int id, Customer cust)
        {
            _CustomerRepository.GetList().Find(c => c.Id == id).Id = cust.Id;
            _CustomerRepository.GetList().Find(c => c.Id == id).Name = cust.Name;
        }
        public void Post(Customer cust)
        {
            _CustomerRepository?.GetList().Add(cust);
        }

    }
}
