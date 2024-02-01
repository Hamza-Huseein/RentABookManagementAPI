using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Reservation;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Repos
{
    public class ReservationRepos : IReservation
    {
        private readonly RentABookManagementAPIDbContext _context;
        public ReservationRepos(RentABookManagementAPIDbContext context)
        {
            _context = context;
        }
        public Task<IActionResult> CreateReservation(ReservationCreateDTO dto)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> DeleteReservation(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetAllReservation()
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> GetReservationById(int Id)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Task<IActionResult> UpdateReservation(ReservationUpdateDTO dto)
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
