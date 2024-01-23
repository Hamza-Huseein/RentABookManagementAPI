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
        public Task CreateBook(BookCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookCardDTO>> GetAllBook()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBook(BookUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
