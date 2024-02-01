using Microsoft.AspNetCore.Mvc;
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
        Task<IActionResult> GetCustomerById(int Id);
        Task<IActionResult> GetAllCustomer();
        Task <IActionResult> CreateCustomer(CustomerCreateDTO dto);
        Task <IActionResult>UpdateCustomer(CustomerUpdateDTO dto);
        Task<IActionResult> DeleteCustomer(int Id);
    }
}
