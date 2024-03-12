using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Entity
{
    public class Room : EntityBase
    {
        [Required]
        public string RoomCategory { get; set; }

        public bool isAvailable { get; set; } = true;

        [Required]
        public int Price { get; set; }

        public string? Description { get; set; }

        public Hotel Hotel { get; set; }
        
        [Required]
        [ForeignKey(nameof(Hotel))]
        public int HotelId { get; set; }

    }
}
