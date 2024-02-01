using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.ReservationItem;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Repos
{
    public class ReservationItemRepos : IReservationItem
    {
        private readonly RentABookManagementAPIDbContext _context;
        public ReservationItemRepos(RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task<IActionResult> CreateReservationItem(ReservationItemCreateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> DeleteReservationItem(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetAllReservationItem()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetReservationItemById(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> UpdateReservationItem(ReservationItemUpdateDTO dto)
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
