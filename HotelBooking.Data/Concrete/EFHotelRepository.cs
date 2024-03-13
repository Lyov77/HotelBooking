using HotelBooking.Data.Abstract;
using HotelBooking.Data.Context;
using HotelBooking.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Concrete
{
    public class EFHotelRepository : IHotelRepository, IDisposable
    {
        private readonly HotelDbContext _context;

        public EFHotelRepository(HotelDbContext dbcontext)
        {
            _context = dbcontext;
        }

        public async Task AddBookingAsync(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task AddHotelAsync(Hotel hotel)
        {
            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task AddRoomAsync(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable<Hotel> GetAllHotels()
        {
            return _context.Hotels.AsQueryable();
        }

        public IQueryable<Room> GetAllRooms(int HotelId)
        {
            return _context.Rooms.Where(r => r.HotelId == HotelId).AsQueryable();
        }

        public async Task<Hotel?> GetHotelbyIdAsync(int HotelId)
        {
            Hotel? hotel = await _context.Hotels.FindAsync(HotelId);
            return hotel;

        }

        public async Task UpdateHotelRatingAsync(int hotelId, int rating)
        {
            Hotel? hotel = await _context.Hotels.FindAsync(hotelId);

            hotel.Rating = (hotel.Rating * hotel.RatingCount + rating) / (hotel.RatingCount + 1);
            hotel.RatingCount++;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoomBookingAsync(int roomId)
        {
            Room? room = await _context.Rooms.FindAsync(roomId);

            if (room.isAvailable)
            {
                room.isAvailable = false;
            }
            else room.isAvailable = true;

            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoomPriceAsync(int roomId, int price)
        {
            Room? room = await _context.Rooms.FindAsync(roomId);
            room.Price = price;
            await _context.SaveChangesAsync();
        }
    }
}
