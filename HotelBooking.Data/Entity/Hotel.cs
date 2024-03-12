using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Entity
{
    public class Hotel : EntityBase
    {
        public Hotel()
        {
            Rooms = new List<Room>();
        }
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Range(1, 11)]
        public float Rating { get; set; }
        
        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        [Range(1, 6)]
        public int Stars { get; set; } = 1;

        public virtual ICollection<Room> Rooms { get; set; }

       

    }
}
