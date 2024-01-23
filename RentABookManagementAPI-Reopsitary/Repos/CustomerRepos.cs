using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Repos
{
    public class CustomerRepos : ICustomer
    {
        public Task CreateCustomer(CustomerCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerCardDTO>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(CustomerUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
