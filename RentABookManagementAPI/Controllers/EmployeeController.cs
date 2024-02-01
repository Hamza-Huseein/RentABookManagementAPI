using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.DTO.Employee;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly RentABookManagementAPIDbContext _context;
        private readonly IEmployee _employee;
        public EmployeeController(RentABookManagementAPIDbContext context, IEmployee employee)
        {
            _context = context;
            _employee = employee;
        }
        /// <summary>
        /// Gets the list of Employee By Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get Employee By Id
        ///     {        
        ///       "ID": "Enter Your Id For Get Employee Here",   
        ///     }
        /// </remarks>
        /// <returns>A newly Get Employee </returns>
        /// <response code="201">Returns the newly Get Employee</response>
        /// <response code="400">If the error was occured</response>  
        [HttpGet]
        [Route("GetEmployeeById/{Id}")]
        public async Task<IActionResult> GetEmployeeById(int Id)
        {
            try
            {
                var Employee = await _context.Employees.FindAsync(Id);

                if (Employee != null)
                {
                    return Ok(Employee);
                }
                else
                {
                    return NotFound($"Employee with Id {Id} not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Gets the list of Allemployee .
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get Allemployee
        ///     {        
        ///       "EmployeeId": "Enter Your EmployeeId For Get Employee Here",  
        ///       "EmployeeName": "Enter Your EmployeeName For Get Employee Here",
        ///       "Position": "Enter Your Position For Get Employee Here",
        ///     }
        /// </remarks>
        /// <returns>A newly Get Allemployee </returns>
        /// <response code="201">Returns the newly Get Allemployee</response>
        /// <response code="400">If the error was occured</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllEmployee()
        {
            try
            {
                var Employee = await _context.Employees.ToListAsync();
                var result = from E in Employee
                             select new EmployeeCardDTO
                             {
                                 EmployeeId = E.EmployeeId,
                                 EmployeeName = E.EmployeeName,
                                 Position = E.Position,
                             };
                return Ok(result.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Add New Employee.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/CreateEmployee
        ///     {        
        ///       "EmployeeId": "Enter new EmployeeId Here",
        ///       "EmployeeName": "Enter new EmployeeName Here",
        ///       "Position": "Enter new Position Here", 
        ///     }
        /// </remarks>
        /// <response code="201">Returns the newly created Employee</response>
        /// <response code="400">If the error was occured</response>       
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateDTO dto)
        {
            try
            {
                Employee E = new Employee();
                E.EmployeeId = dto.EmployeeId;
                E.EmployeeName = dto.EmployeeName;
                E.Position = dto.Position;
                await _context.AddAsync(E);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Update the list of Employee.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Put api/UpdateEmployee                                                    
        ///     {                                                                             
        ///       "EmployeeId": "Enter your EmployeeId edit here",
        ///       "EmployeeName": "Enter your EmployeeName edit here",
        ///       "Position": "Enter your Position edit here",
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly edit Employee </response>            
        /// <response code="400">If the error was occured</response> 
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateEmployee(EmployeeUpdateDTO dto)
        {
            var result = await _context.Employees.FindAsync(dto.EmployeeId);
            if (result != null)
            {
                result.EmployeeId = dto.EmployeeId;
                result.EmployeeName = dto.EmployeeName;
                result.Position = dto.Position;
                _context.Update(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        /// <summary>
        ///Delete the Employee by id.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Delete api/DeleteEmployee                                                    
        ///     {                                                                             
        ///       "ID": "Enter id for delete here",                                
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly Delete Employee</response>            
        /// <response code="400">If the error was occured</response>
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteEmployee(int Id)
        {
            var result = await _context.Employees.FindAsync(Id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
    }
}
