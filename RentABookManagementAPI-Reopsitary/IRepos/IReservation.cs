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
        Task<Reservation> GetReservationById(int Id);
        Task<List<ReservationCardDTO>> GetAllReservation();
        Task CreateReservation(ReservationCreateDTO dto);
        Task UpdateReservation(ReservationUpdateDTO dto);
        Task DeleteReservation(int Id);
    }
}
