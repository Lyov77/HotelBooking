using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectShared.SharedModels
{
    public class HotelViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, 11)]
        public float Rating { get; set; }

        public int RatingCount { get; set; }
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        [Range(1, 6)]
        public int Stars { get; set; } = 1;
    }
}
