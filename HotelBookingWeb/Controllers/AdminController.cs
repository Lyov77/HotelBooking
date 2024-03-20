using Microsoft.AspNetCore.Mvc;

namespace HotelBookingWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
