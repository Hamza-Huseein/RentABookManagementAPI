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
        Task<ReservationItem> GetReservationItemById(int Id);
        Task<List<ReservationItemCardDTO>> GetAllReservationItem();
        Task CreateReservationItem(ReservationItemCreateDTO dto);
        Task UpdateReservationItem(ReservationItemUpdateDTO dto);
        Task DeleteReservationItem(int Id);
    }
}
