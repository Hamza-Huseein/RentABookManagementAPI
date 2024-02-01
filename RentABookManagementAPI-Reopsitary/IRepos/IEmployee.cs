using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.DTO.Employee;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.IRepos
{
    public interface IEmployee
    {
        Task<IActionResult> GetEmployeeById(int Id);
        Task<IActionResult> GetAllEmployee();
        Task<IActionResult> CreateEmployee(EmployeeCreateDTO dto);
        Task<IActionResult> UpdateEmployee(EmployeeUpdateDTO dto);
        Task<IActionResult> DeleteEmployee(int Id);
    }
}
