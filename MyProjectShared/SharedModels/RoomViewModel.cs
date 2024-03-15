using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectShared.SharedModels
{
    public class RoomViewModel
    {
        [Required]
        public string RoomCategory { get; set; } = string.Empty;
        [Required]
        public int Price { get; set; }
        public string? Description { get; set; }
        [Required]
        public int HotelId { get; set; }
    }
}
