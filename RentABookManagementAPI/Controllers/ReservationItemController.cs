using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Reservation;
using RentABookManagementAPI_Reopsitary.DTO.ReservationItem;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationItemController : ControllerBase
    {
        private readonly RentABookManagementAPIDbContext _context;
        private readonly IReservationItem _reservationItem;
        public ReservationItemController(RentABookManagementAPIDbContext context, IReservationItem reservationItem)
        {
            _context = context;
            _reservationItem = reservationItem;
        }
        /// <summary>
        /// Gets the list of ReservationItem By Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get ReservationItem By Id
        ///     {        
        ///       "ID": "Enter Your Id For Get ReservationItem Here",   
        ///     }
        /// </remarks>
        /// <returns>A newly Get ReservationItem </returns>
        /// <response code="201">Returns the newly Get ReservationItem</response>
        /// <response code="400">If the error was occured</response>  
        [HttpGet]
        [Route("GetReservationItemById/{Id}")]
        public async Task<IActionResult> GetReservationItemById(int Id)
        {
            try
            {
                var ReservationItem = await _context.ReservationItems.FindAsync(Id);

                if (ReservationItem != null)
                {
                    return Ok(ReservationItem);
                }
                else
                {
                    return NotFound($"ReservationItem with Id {Id} not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Gets the list of AllReservationItem .
        /// </summary>
        /// <returns>A newly Get AllReservationItem </returns>
        /// <response code="201">Returns the newly Get AllReservationItem
        /// </response>
        /// <response code="400">If the error was occured</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllReservationItem()
        {
            try
            {
                var ReservationItem = await _context.ReservationItems.ToListAsync();
                var result = from RI in ReservationItem
                             select new ReservationItemCardDTO
                             {
                                 BookId = RI.BookId,
                                 ReservationId = RI.ReservationId,
                                 Price = RI.Price,
                             };
                return Ok(result.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Add New ReservationItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/CreateReservationItem
        ///     {        
        ///       "BookId": "Enter new BookId Here",
        ///       "ReservationId": "Enter new ReservationId Here",
        ///       "Price": "Enter new Price Here",
        /// </remarks>
        /// <response code="201">Returns the newly created ReservationItem</response>
        /// <response code="400">If the error was occured</response>       
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateReservationItem(ReservationItemCreateDTO dto)
        {
            try
            {
                ReservationItem RI = new ReservationItem();
                RI.BookId = dto.BookId;
                RI.ReservationId = dto.ReservationId;
                RI.Price = dto.Price;
                await _context.AddAsync(RI);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Update the list of ReservationItem.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Put api/UpdateReservationItem                                                   
        ///     {                                                                             
        ///       "BookId": "Enter your BookId edit Here",
        ///       "ReservationId": "Enter your ReservationId edit Here",
        ///       "Price": "Enter your Price edit Here",                      
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly edit ReservationItem </response>            
        /// <response code="400">If the error was occured</response> 
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateReservationItem(ReservationItemUpdateDTO dto)
        {
            var result = await _context.ReservationItems.FindAsync(dto.ReservationId ,dto.BookId);
            if (result != null)
            {
                result.ReservationId = dto.ReservationId;
                result.BookId = dto.BookId;
                result.Price = dto.Price;
                _context.Update(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        /// <summary>
        ///Delete the ReservationItem by id.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Delete api/DeleteReservationItem                                                   
        ///     {                                                                             
        ///       "ID": "Enter id for delete here",                                
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly Delete ReservationItem</response>            
        /// <response code="400">If the error was occured</response>
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteReservationItem(int Id)
        {
            var result = await _context.ReservationItems.FindAsync(Id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

    }
}
