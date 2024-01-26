using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.DTO.ReservationItem
{
    public class ReservationItemUpdateDTO
    {
        public int BookId { get; set; }
        public int ReservationId { get; set; }
        public int Price { get; set; }
    }
}
