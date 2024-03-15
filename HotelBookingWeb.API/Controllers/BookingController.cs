using HotelBooking.Data.Abstract;
using HotelBooking.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyProjectShared.SharedModels;

namespace HotelBookingWeb.API.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly IHotelRepository _hotelRepository;

        public BookingController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }


        [HttpGet]
        [Route("All")]
        public IActionResult All()
        {
            var bookings = _hotelRepository.GetAllBookings().ToList();
            return Ok(bookings);
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(BookingViewModel bookingViewModel)
        {
            Room roomToBook = new Room();
            roomToBook.Id = bookingViewModel.RoomId;

            Booking booking = new()
            {
                StartDate = bookingViewModel.StartDate,
                DaysNumber = bookingViewModel.DaysNumber,
                UserId = bookingViewModel.UserId,
                RoomId = bookingViewModel.RoomId,
                Amount = bookingViewModel.DaysNumber * roomToBook.Price
            };

            if (ModelState.IsValid && roomToBook.isAvailable)
            {
                await _hotelRepository.AddBookingAsync(booking);
                await _hotelRepository.UpdateRoomBookingAsync(booking.RoomId);

                return Ok(booking);
            }

            return NotFound("Booking NOT added!");
        }
    }
}
