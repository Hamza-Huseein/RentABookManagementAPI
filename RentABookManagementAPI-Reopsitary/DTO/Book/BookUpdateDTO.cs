using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.DTO.BookDTO
{
    public class BookUpdateDTO
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
