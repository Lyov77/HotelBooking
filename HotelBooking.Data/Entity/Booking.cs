using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Entity
{
    public class Booking : EntityBase
    {
        public DateTime StartDate { get; set; }
        public int DaysNumber { get; set; }

        [Required]
        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

        public virtual Room? Room { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User? User { get; set; }

        public int Amount { get; set; }
    }
}
