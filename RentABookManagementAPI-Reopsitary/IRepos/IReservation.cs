using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.DTO.Customer;
using RentABookManagementAPI_Reopsitary.DTO.Reservation;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.IRepos
{
    public interface IReservation
    {
        Task<IActionResult> GetReservationById(int Id);
        Task<IActionResult> GetAllReservation();
        Task<IActionResult> CreateReservation(ReservationCreateDTO dto);
        Task<IActionResult> UpdateReservation(ReservationUpdateDTO dto);
        Task<IActionResult> DeleteReservation(int Id);
    }
}
