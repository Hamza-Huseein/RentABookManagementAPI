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
        public Task CreateReservation(ReservationCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReservation(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReservationCardDTO>> GetAllReservation()
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetReservationById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservation(ReservationUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
