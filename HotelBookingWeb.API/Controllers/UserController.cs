using HotelBooking.Data.Abstract;
using HotelBooking.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyProjectShared.SharedModels;

namespace HotelBookingWeb.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IHotelRepository _hotelRepository;

        public UserController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(UserViewModel userViewModel)
        {
            User user = new()
            {
                FullName = userViewModel.FullName,
                Email = userViewModel.Email,
                Login = userViewModel.Login,
                Password = userViewModel.Password,
                PhoneNumber = userViewModel.PhoneNumber
            };

            if (ModelState.IsValid)
            {
                await _hotelRepository.AddUserAsync(user);
                return Ok(user);
            }

            return NotFound("Hotel NOT added!");
        }
    }
}
