using Microsoft.AspNetCore.Mvc;

namespace RentABookManagementAPI.Controllers
{
    public class ReservationItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
