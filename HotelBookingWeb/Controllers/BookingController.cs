using Microsoft.AspNetCore.Mvc;

namespace HotelBookingWeb.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
