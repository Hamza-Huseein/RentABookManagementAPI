using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
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
        private readonly RentABookManagementAPIDbContext _context;
        public CustomerRepos(RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task<IActionResult> CreateCustomer(CustomerCreateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> DeleteCustomer(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetAllCustomer()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetCustomerById(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> UpdateCustomer(CustomerUpdateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
