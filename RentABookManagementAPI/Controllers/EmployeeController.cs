using Microsoft.AspNetCore.Mvc;

namespace RentABookManagementAPI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
