using HotelBookingWeb.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> HotelUsers { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
   /* public class ApplicationUser : IdentityUser
    {

    }*/
}
