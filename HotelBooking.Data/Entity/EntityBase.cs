using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Data.Entity
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
