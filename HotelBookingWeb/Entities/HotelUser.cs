using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingWeb.Entities
{
    public class User : IdentityUser
    {
        [Required]
        public string FullName { get; set; } = string.Empty;
    }
}
