using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Employee;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller, IEmployee
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        public Task<List<EmployeeCardDTO>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task CreateEmployee(EmployeeCreateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateEmployee(EmployeeUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
