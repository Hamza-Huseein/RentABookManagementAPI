using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller, ICustomer
    {
        private readonly RentABookManagementAPIDbContext _context;
        public CustomerController(RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task<List<CustomerCardDTO>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task CreateCustomer(CustomerCreateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateCustomer(CustomerUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteCustomer(int Id)
        {
            throw new NotImplementedException();
        }
        
    }
}
