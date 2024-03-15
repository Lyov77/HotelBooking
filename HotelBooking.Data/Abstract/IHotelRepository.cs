using HotelBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Abstract
{
    public interface IHotelRepository
    {
        IQueryable<Hotel> GetAllHotels();
        IQueryable<Booking> GetAllBookings();
        IQueryable<Room> GetAllRooms(int HotelId);
        Task<Hotel?> GetHotelbyIdAsync(int HotelId);
        Task UpdateHotelRatingAsync(int hotelId, int rating);
        Task UpdateRoomPriceAsync(int roomId, int price);
        Task UpdateRoomBookingAsync(int roomId);
        Task AddBookingAsync(Booking booking);
        Task AddHotelAsync(Hotel hotel);
        Task AddRoomAsync(Room room);
        Task AddUserAsync(User user);

    }
}
