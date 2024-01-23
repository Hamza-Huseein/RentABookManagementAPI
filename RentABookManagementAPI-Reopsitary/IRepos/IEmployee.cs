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
        Task<Employee> GetEmployeeById(int Id);
        Task<List<EmployeeCardDTO>> GetAllEmployee();
        Task CreateEmployee(EmployeeCreateDTO dto);
        Task UpdateEmployee(EmployeeUpdateDTO dto);
        Task DeleteEmployee(int Id);
    }
}
