using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Employee;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Repos
{
    public class EmployeeRepos : IEmployee
    {
        private readonly RentABookManagementAPIDbContext _context;
        public EmployeeRepos(RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task<IActionResult> CreateEmployee(EmployeeCreateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetAllEmployee()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> UpdateEmployee(EmployeeUpdateDTO dto)
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
