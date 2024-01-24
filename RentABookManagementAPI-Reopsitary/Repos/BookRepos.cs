using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.BookDTO;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Repos
{
    public class BookRepos : IBook
    {
        private readonly RentABookManagementAPIDbContext _context; 
        public BookRepos (RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task CreateBook(BookCreateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex) 
            {
            
            }
           
        }

        public Task DeleteBook(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<List<BookCardDTO>> GetAllBook()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<Book> GetBookById(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task UpdateBook(BookUpdateDTO dto)
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
