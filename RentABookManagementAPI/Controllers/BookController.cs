using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.BookDTO;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly RentABookManagementAPIDbContext _context;
        private readonly IBook _book;
        public BookController(RentABookManagementAPIDbContext context, IBook  book)
        {
            _context = context;
            _book = book;
        }

        /// <summary>
        /// Gets the list of Book By Id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get Book By Id
        ///     {        
        ///       "ID": "Enter Your Id For Get Book Here",   
        ///     }
        /// </remarks>
        /// <returns>A newly Get Book </returns>
        /// <response code="201">Returns the newly Get Book</response>
        /// <response code="400">If the error was occured</response>  
        [HttpGet]
        [Route("GetBookById/{Id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int Id)
        {
            try
            {
                Log.Debug($"Debuggin GetBookById Has Been Started With Book Id ={Id} ");
                var book = await _context.Books.FindAsync(Id);

                if (book != null)
                {
                    Log.Information("Book Is Existing");
                    return Ok(book);
                    Log.Debug($"Debuggin GetBookById Has Been Finished With Book Id ={Id} ");

                }
                else
                {
                    Log.Error($"Book with Id {Id} not found");
                    return NotFound($"Book with Id {Id} not found");
                }
            }
            catch
            {
                return BadRequest();
            }


        }
        /// <summary>
        /// Gets the list of AllBook .
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     Get api/Get AllBook
        ///     {        
        ///       "BookId": "Enter Your Id For Get Book Here",  
        ///       "BookName": "Enter Your BookName For Get Book Here",
        ///       "Description": "Enter Your Description For Get Book Here",
        ///       "Author": "Enter Your Author For Get Book Here",
        ///       "PricePerDay": "Enter Your PricePerDay For Get Book Here",
        ///     }
        /// </remarks>
        /// <returns>A newly Get AllBook </returns>
        /// <response code="201">Returns the newly Get AllBook</response>
        /// <response code="400">If the error was occured</response>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBook()
        {
            try
            {
                var Book = await _context.Books.ToListAsync();
                var result = from b in Book
                             select new BookCardDTO
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 Description = b.Description,
                                 Author = b.Author,
                                 PricePerDay = b.PricePerDay,
                             };
                return Ok(result.ToList());
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Add New Book.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/CreateBook
        ///     {        
        ///       "BookName": "Enter new BookName Here",
        ///       "Author": "Enter new Author Here",
        ///       "Description": "Enter new Description Here", 
        ///       "PricePerDay": "Enter new PricePerDay Here", 
        ///     }
        /// </remarks>
        /// <response code="201">Returns the newly created book</response>
        /// <response code="400">If the error was occured</response>       
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateBook(BookCreateDTO dto)
        {
            try
            {
                Book b = new Book();
                b.BookName = dto.BookName;
                b.Author = dto.Author;
                b.Description = dto.Description;
                b.PricePerDay = dto.PricePerDay;
                await _context.AddAsync(b);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Update the list of Book.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Put api/UpdateBook                                                    
        ///     {                                                                             
        ///       "BookId": "Enter your BookId edit here",
        ///       "BookName": "Enter your BookName edit here",
        ///       "Author": "Enter your Author edit here",
        ///       "Description": "Enter your Description edit here",
        ///       "PricePerDay": "Enter your PricePerDay edit here",
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly edit Book </response>            
        /// <response code="400">If the error was occured</response> 
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBook([FromRoute] int id ,  BookUpdateDTO dto)
        {
            var result = await _context.Books.FindAsync(dto.BookId);
            if (result != null)
            {
                result.BookId = dto.BookId;
                result.BookName = dto.BookName;
                result.Author = dto.Author;
                result.Description = dto.Description;
                result.PricePerDay = dto.PricePerDay;
                _context.Update(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }
        /// <summary>
        ///Delete the Book by id.
        /// </summary>
        /// <remarks>                                                                         
        /// Sample request:                                                                   
        ///                                                                                   
        ///     Delete api/DeleteBook                                                    
        ///     {                                                                             
        ///       "ID": "Enter id for delete here",                                
        ///     }                                                                             
        /// </remarks>                                                                        
        /// <response code="201">Returns the newly Delete Book</response>            
        /// <response code="400">If the error was occured</response>
        [HttpDelete]
        [Route("[action]")]
        public async Task DeleteBook(int Id)
        {
            var result = await _context.Books.FindAsync(Id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }
        }
    }
}

