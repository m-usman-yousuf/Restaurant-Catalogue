
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RestaurantMenu.Dtos
{
    public class RestaurantUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]

        public string Address { get; set; }

    }

}