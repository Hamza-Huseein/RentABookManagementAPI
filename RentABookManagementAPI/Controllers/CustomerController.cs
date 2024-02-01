using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.BookDTO;
using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly RentABookManagementAPIDbContext _context;
        private readonly ICustomer _customer;
        public CustomerController(RentABookManagementAPIDbContext context, ICustomer customer)
        {
            _context = context;
            _customer = customer;
        }
        /// <summary>
        /// Gets the list of Customer By Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get Customer By Id
        ///     {        
        ///       "ID": "Enter Your Id For Get Customer Here",   
        ///     }
        /// </remarks>
        /// <returns>A newly Get Customer </returns>
        /// <response code="201">Returns the newly Get Customer</response>
        /// <response code="400">If the error was occured</response>  
        [HttpGet]
        [Route("GetCustomerById/{Id}")]
        public async Task<IActionResult> GetCustomerById(int Id)
        {
            try
            {
                var employee = await _context.Customers.FindAsync(Id);

                if (employee != null)
                {
                    return Ok(employee);
                }
                else
                {
                    return NotFound($"employee with Id {Id} not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Gets the list of AllCustomer .
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get AllCustomer
        ///     {        
        ///       "CustomerId": "Enter Your CustomerId For Get Customer Here",  
        ///       "CustomerName": "Enter Your CustomerName For Get Customer Here",
        ///       "Email": "Enter Your Email For Get Customer Here",
        ///       "Phone": "Enter Your Phone For Get Customer Here",
        ///     }
        /// </remarks>
        /// <returns>A newly Get AllCustomer </returns>
        /// <response code="201">Returns the newly Get AllCustomer</response>
        /// <response code="400">If the error was occured</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllCustomer()
        {
            try
            {
                var Customer = await _context.Customers.ToListAsync();
                var result = from C in Customer
                             select new CustomerCardDTO
                             {
                                 CustomerId = C.CustomerId,
                                 CustomerName = C.CustomerName,
                                 Email = C.Email,
                                 Phone = C.Phone,
                             };
                return Ok(result.ToList());
            }
            catch (Exception ex) 
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Add New Customer.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/CreateCustomer
        ///     {        
        ///       "CustomerId": "Enter new CustomerId Here",
        ///       "CustomerName": "Enter new CustomerName Here",
        ///       "Email": "Enter new Email Here", 
        ///       "Phone": "Enter new Phone Here", 
        ///     }
        /// </remarks>
        /// <response code="201">Returns the newly created Customer</response>
        /// <response code="400">If the error was occured</response>       
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult>CreateCustomer(CustomerCreateDTO dto)
        {
            try
            {
                Customer CU = new Customer();
                CU.CustomerId = dto.CustomerId;
                CU.CustomerName = dto.CustomerName;
                CU.Email = dto.Email;
                CU.Phone = dto.Phone;
                await _context.AddAsync(CU);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            { 
                return BadRequest(); 
            }
        }
        /// <summary>
        /// Update the list of Customer.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Put api/UpdateCustomer                                                    
        ///     {                                                                             
        ///       "CustomerId": "Enter your CustomerId edit here",
        ///       "CustomerName": "Enter your CustomerName edit here",
        ///       "Email": "Enter your Email edit here",
        ///       "Phone": "Enter your Phone edit here",
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly edit Customer </response>            
        /// <response code="400">If the error was occured</response> 
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCustomer(CustomerUpdateDTO dto)
        {
            var result = await _context.Customers.FindAsync(dto.CustomerId);
            if (result != null)
            {
                result.CustomerId = dto.CustomerId;
                result.CustomerName = dto.CustomerName;
                result.Email = dto.Email;
                result.Phone = dto.Phone;
                _context.Update(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        /// <summary>
        ///Delete the Customer by id.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Delete api/DeleteCustomer                                                    
        ///     {                                                                             
        ///       "ID": "Enter id for delete here",                                
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly Delete Customer</response>            
        /// <response code="400">If the error was occured</response>
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteCustomer(int Id)
        {
            var result = await _context.Customers.FindAsync(Id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
        
    }
}
