using Microsoft.AspNetCore.Mvc;

namespace RentABookManagementAPI.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
