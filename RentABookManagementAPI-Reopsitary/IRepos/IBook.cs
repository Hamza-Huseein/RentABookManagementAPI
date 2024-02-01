using Microsoft.AspNetCore.Mvc;
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
        Task<IActionResult> GetBookById(int Id);
        Task<IActionResult> GetAllBook();
        Task <IActionResult> CreateBook(BookCreateDTO dto);
        Task <IActionResult> UpdateBook(BookUpdateDTO dto);
        Task <IActionResult> DeleteBook(int Id);

    }
}
