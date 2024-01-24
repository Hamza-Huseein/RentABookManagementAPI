using Microsoft.AspNetCore.Mvc;
using RentABookManagementAPI_Reopsitary.Context;
using RentABookManagementAPI_Reopsitary.DTO.ReservationItem;
using RentABookManagementAPI_Reopsitary.IRepos;
using RentABookManagementAPI_Reopsitary.Models.Entity;

namespace RentABookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationItemController : Controller, IReservationItem
    {
        private readonly IReservationItem _reservationItem;
        public ReservationItemController(IReservationItem reservationItem)
        {
            _reservationItem = reservationItem;
        }
        public Task<List<ReservationItemCardDTO>> GetAllReservationItem()
        {
            throw new NotImplementedException();
        }

        public Task<ReservationItem> GetReservationItemById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task CreateReservationItem(ReservationItemCreateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateReservationItem(ReservationItemUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteReservationItem(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
