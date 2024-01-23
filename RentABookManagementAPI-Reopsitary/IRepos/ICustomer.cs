using RentABookManagementAPI_Reopsitary.DTO.BookDTO;
using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.IRepos
{
    public interface ICustomer
    {
        Task<Customer> GetCustomerById(int Id);
        Task<List<CustomerCardDTO>> GetAllCustomer();
        Task CreateCustomer(CustomerCreateDTO dto);
        Task UpdateCustomer(CustomerUpdateDTO dto);
        Task DeleteCustomer(int Id);
    }
}
