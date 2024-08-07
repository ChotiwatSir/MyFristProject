using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFristProject.Dtos;
using MyFristProject.Entities;
using MyFristProject.IRepositories;
using MyFristProject.IServices;

namespace MyFristProject.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public CousinCustomerDto CousinCustomer(Guid customerId)
        {
            var cousinCustomer = _customerRepository.Table.Where(c => c.Id == customerId)
                                                                .Select(cd => new CousinCustomerDto(
                                                                                    cd.CustomerDetail.Id,
                                                                                    cd.CustomerDetail.FristName + " " + cd.CustomerDetail.LastName,
                                                                                    cd.CustomerDetail.CousinCustomers
                                                                                                                .Select(cl => new CousinListNameDto(cl.Id, cl.Name))
                                                                                                                .ToList()
                                                                                    )).FirstOrDefault() ?? throw new Exception("ควย");

            return cousinCustomer;
        }
    }
}