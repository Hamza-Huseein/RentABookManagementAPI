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
        public Task CreateEmployee(EmployeeCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeCardDTO>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(EmployeeUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
