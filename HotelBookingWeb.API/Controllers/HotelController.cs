using HotelBooking.Data.Abstract;
using HotelBooking.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyProjectShared.SharedModels;

namespace HotelBookingWeb.API.Controllers
{
    [Route("api/[controller]")]
    public class HotelController : Controller
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult All()
        {
            var hotels = _hotelRepository.GetAllHotels().ToList();
            return Ok(hotels);
        }

        [HttpGet]
        [Route("Id")]
        public async Task<IActionResult> HotelById(int id)
        {
            Hotel? hotel = await _hotelRepository.GetHotelbyIdAsync(id);

            if (hotel == null)
            {
                return NotFound("Hotel not found");
            }
            return Ok(hotel);
        }

        [HttpPost]
        [Route("Rating")]
        public async Task<IActionResult> UpdateRating(int hotelId, int rating)
        {
            if (ModelState.IsValid)
            {
                await _hotelRepository.UpdateHotelRatingAsync(hotelId, rating);

                return Ok();
            }
            return NotFound("Error! Rating NOT added!");
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(HotelViewModel hotelViewModel)
        {
            Hotel hotel = new()
            {
                City = hotelViewModel.City,
                Stars = hotelViewModel.Stars
            };

            if (ModelState.IsValid)
            {
                await _hotelRepository.AddHotelAsync(hotel);

                return Ok(hotel);
            }

            return NotFound("Hotel NOT added!");
        }
    }
}
