using Microsoft.AspNetCore.Mvc;

namespace HotelBookingWeb.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
