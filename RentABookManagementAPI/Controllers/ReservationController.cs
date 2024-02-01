using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Employee;
using RentABookManagementAPI_Reopsitary.DTO.Reservation;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly RentABookManagementAPIDbContext _context;
        private readonly IReservation _reservation;
        public ReservationController(RentABookManagementAPIDbContext context, IReservation reservation)
        {
            _context = context;
            _reservation = reservation;
        }
        /// <summary>
        /// Gets the list of Reservation By Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get Reservation By Id
        ///     {        
        ///       "ID": "Enter Your Id For Get Reservation Here",   
        ///     }
        /// </remarks>
        /// <returns>A newly Get Reservation </returns>
        /// <response code="201">Returns the newly Get Reservation</response>
        /// <response code="400">If the error was occured</response>  
        [HttpGet]
        [Route("GetReservationById/{Id}")]
        public async Task<IActionResult> GetReservationById(int Id)
        {
            try
            {
                var Reservation = await _context.Reservations.FindAsync(Id);

                if (Reservation != null)
                {
                    return Ok(Reservation);
                }
                else
                {
                    return NotFound($"Reservation with Id {Id} not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Gets the list of AllReservation .
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get AllReservation
        ///     {        
        ///       "ReservationId": "Enter Your ReservationId For Get Reservation Here",  
        ///       "ReservationNumber": "Enter Your ReservationNumber For Get Reservation Here",
        ///       "TotalPrice": "Enter Your TotalPrice For Get Reservation Here",
        ///       "StartDate": "Enter Your StartDate For Get Reservation Here",
        ///       "EndDate": "Enter Your EndDate For Get Reservation Here",
        ///       "CustomerId": "Enter Your CustomerId For Get Reservation Here",
        ///       "EmployeeId": "Enter Your EmployeeId For Get Reservation Here",
        ///     }
        /// </remarks>
        /// <returns>A newly Get AllReservation </returns>
        /// <response code="201">Returns the newly Get AllReservation
        /// </response>
        /// <response code="400">If the error was occured</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllReservation()
        {
            try
            {
                var Reservation = await _context.Reservations.ToListAsync();
                var result = from R in Reservation
                             select new ReservationCardDTO
                             {
                                 ReservationId=R.ReservationId,
                                 ReservationNumber = R.ReservationNumber,
                                 TotalPrice = R.TotalPrice,
                                 StartDate = R.StartDate,   
                                 EndDate = R.EndDate,
                                 CustomerId = R.CustomerId,
                                 EmployeeId = R.EmployeeId,
                             };
                return Ok(result.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Add New Reservation.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/CreateReservation
        ///     {        
        ///       "ReservationId": "Enter new ReservationId Here",
        ///       "ReservationNumber": "Enter new ReservationNumber Here",
        ///       "TotalPrice": "Enter new TotalPrice Here",
        ///       "StartDate": "Enter new StartDate Here",
        ///       "EndDate": "Enter new EndDate Here",
        ///       "CustomerId": "Enter new CustomerId Here",
        ///       "EmployeeId": "Enter new EmployeeId Here",
        ///     }
        /// </remarks>
        /// <response code="201">Returns the newly created Reservation</response>
        /// <response code="400">If the error was occured</response>       
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateReservation(ReservationCreateDTO dto)
        {
            try
            {
                Reservation R = new Reservation();
                R.ReservationId = dto.ReservationId;
                R.ReservationNumber = dto.ReservationNumber;
                R.TotalPrice = dto.TotalPrice;
                R.StartDate = dto.StartDate;
                R.EndDate = dto.EndDate;
                R.CustomerId = dto.CustomerId;
                R.EmployeeId = dto.EmployeeId;
                await _context.AddAsync(R);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Update the list of Reservation.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Put api/UpdateReservation                                                    
        ///     {                                                                             
        ///       "ReservationId": "Enter your ReservationId edit Here",
        ///       "ReservationNumber": "Enter your ReservationNumber edit Here",
        ///       "TotalPrice": "Enter your TotalPrice edit Here",
        ///       "StartDate": "Enter your StartDate edit Here",
        ///       "EndDate": "Enter your EndDate edit Here",
        ///       "CustomerId": "Enter your CustomerId edit Here",
        ///       "EmployeeId": "Enter your EmployeeId edit Here",                         
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly edit Reservation </response>            
        /// <response code="400">If the error was occured</response> 
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateReservation(ReservationUpdateDTO dto)
        {
            var result = await _context.Reservations.FindAsync(dto.ReservationId);
            if (result != null)
            {
                result.ReservationId = dto.ReservationId;
                result.ReservationNumber = dto.ReservationNumber;
                result.TotalPrice = dto.TotalPrice;
                result.StartDate = dto.StartDate;
                result.EndDate = dto.EndDate;
                result.CustomerId = dto.CustomerId;
                result.EmployeeId = dto.EmployeeId;
                _context.Update(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        /// <summary>
        ///Delete the Reservation by id.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Delete api/DeleteReservation                                                    
        ///     {                                                                             
        ///       "ID": "Enter id for delete here",                                
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly Delete Reservation</response>            
        /// <response code="400">If the error was occured</response>
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteReservation(int Id)
        {
            var result = await _context.Reservations.FindAsync(Id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

    }
}
