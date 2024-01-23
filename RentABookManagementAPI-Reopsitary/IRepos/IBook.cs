using RentABookManagementAPI_Reopsitary.DTO.BookDTO;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.IRepos
{
    public interface IBook
    {
        Task<Book> GetBookById(int Id);
        Task<List<BookCardDTO>> GetAllBook();
        Task CreateBook(BookCreateDTO dto);
        Task UpdateBook(BookUpdateDTO dto);
        Task DeleteBook(int Id);

    }
}
