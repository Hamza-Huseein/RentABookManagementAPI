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
        public Task CreateReservationItem(ReservationItemCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReservationItem(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReservationItemCardDTO>> GetAllReservationItem()
        {
            throw new NotImplementedException();
        }

        public Task<ReservationItem> GetReservationItemById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservationItem(ReservationItemUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
