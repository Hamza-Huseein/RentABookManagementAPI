using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.Reservation;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller, IReservation
    {
        private readonly IReservation _reservation;
        public ReservationController(IReservation reservation)
        {
            _reservation = reservation;
        }
        public Task<List<ReservationCardDTO>> GetAllReservation()
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetReservationById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task CreateReservation(ReservationCreateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateReservation(ReservationUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteReservation(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
