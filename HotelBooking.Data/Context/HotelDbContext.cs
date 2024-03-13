using HotelBooking.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Context
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Agababyans", Stars = 5, City = "Yerevan" },
                new Hotel { Id = 2, Name = " Mariot", Stars = 5, City = "Caxkadzor" }
                );
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, HotelId = 1, RoomCategory = "Standart", Price = 100 },
                new Room { Id = 2, HotelId = 2, RoomCategory = "President", Price = 1500 }
                );
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FullName = "Artur Abrahamyan", Email = "a.abrahamyan@example.com", Login = "artur.a", Password = "abraham777" });

            modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 1, StartDate = DateTime.Now, DaysNumber = 3, UserId = 1, RoomId = 1 });

        }


    }
}
