using Microsoft.AspNetCore.Mvc;

namespace RentABookManagementAPI.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
