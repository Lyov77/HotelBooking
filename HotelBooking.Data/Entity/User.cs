using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Entity
{
    public class User : EntityBase
    {
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public string? Email { get; set; } = string.Empty;
        [Required]
        public string Login { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
    }
}
