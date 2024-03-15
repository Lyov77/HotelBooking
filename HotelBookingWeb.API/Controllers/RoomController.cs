using HotelBooking.Data.Abstract;
using HotelBooking.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyProjectShared.SharedModels;

namespace HotelBookingWeb.API.Controllers
{
    [Route("api/[controller]")]
    public class RoomController : Controller
    {
        private readonly IHotelRepository _hotelRepository;

        public RoomController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult All(int hotelId)
        {
            var rooms = _hotelRepository.GetAllRooms(hotelId).ToList();
            return Ok(rooms);
        }


        [HttpPost]
        [Route("Price")]
        public async Task<IActionResult> UpdatePrice(int roomId, int price)
        {
            if (ModelState.IsValid && price > 0)
            {
                await _hotelRepository.UpdateRoomPriceAsync(roomId, price);
                return Ok();
            }
            return NotFound("Room NOT found!");
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(RoomViewModel roomViewModel)
        {
            Room room = new()
            {
                RoomCategory = roomViewModel.RoomCategory,
                Description = roomViewModel.Description,
                Price = roomViewModel.Price,
                HotelId = roomViewModel.HotelId
            };

            if (ModelState.IsValid)
            {
                await _hotelRepository.AddRoomAsync(room);

                return Ok(room);
            }

            return NotFound("Room NOT added!");
        }
    }
}
