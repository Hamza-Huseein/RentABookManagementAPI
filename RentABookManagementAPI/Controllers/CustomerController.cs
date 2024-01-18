using Microsoft.AspNetCore.Mvc;

namespace RentABookManagementAPI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
