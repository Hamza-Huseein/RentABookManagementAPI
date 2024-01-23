using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.BookDTO;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase , IBook
    {
        private readonly RentABookManagementAPIDbContext _context;
        public BookController(RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task<List<BookCardDTO>> GetAllBook()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task CreateBook(BookCreateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateBook(BookUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
