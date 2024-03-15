using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectShared.SharedModels
{
    public class BookingViewModel
    {
        public DateTime StartDate { get; set; }
        public int DaysNumber { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public int UserId { get; set; }

        public int Amount { get; set; }
    }
}
