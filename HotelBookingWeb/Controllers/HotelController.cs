using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelBookingWeb.Controllers
{
    public class HotelController : Controller
    {
       
        private readonly HttpClient _httpClient;

        public HotelController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IActionResult> Index()
        {
            // Make request to your API to fetch hotel data
            var response = await _httpClient.GetAsync("https://localhost:7237/api/Hotel/All");
            
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var hotels = JsonConvert.DeserializeObject<List<HotelViewModel>>(responseBody);

            // Pass hotels to the view
            return View(hotels);
        }

        public IActionResult Get()
        {

            return View();
        }
    }
}
