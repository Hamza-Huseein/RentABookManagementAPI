using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.DTO.Reservation;
using RentABookManagementAPI_Reopsitary.DTO.ReservationItem;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.IRepos
{
    public interface IReservationItem
    {
        Task<IActionResult> GetReservationItemById(int Id);
        Task<IActionResult> GetAllReservationItem();
        Task<IActionResult> CreateReservationItem(ReservationItemCreateDTO dto);
        Task<IActionResult> UpdateReservationItem(ReservationItemUpdateDTO dto);
        Task<IActionResult> DeleteReservationItem(int Id);
    }
}
