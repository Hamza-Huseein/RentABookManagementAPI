using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Models.Entity
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int ReservationNumber { get; set; }
        public List<ReservationItem> Reservationtems { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public virtual List<Employee> Employees { get; set; }


    }
}
