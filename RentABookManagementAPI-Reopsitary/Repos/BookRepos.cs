using Microsoft.AspNetCore.Mvc;
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
        public Task<IActionResult> CreateBook(BookCreateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex) 
            {
            
            }
           
        }

        public Task<IActionResult> DeleteBook(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public async Task<IActionResult> GetAllBook()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public async Task<IActionResult> GetBookById(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> UpdateBook(BookUpdateDTO dto)
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
