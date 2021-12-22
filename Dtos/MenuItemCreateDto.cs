using System.ComponentModel.DataAnnotations;

namespace RestaurantMenu.Dtos
{
    public class MenuItemCreateDto
    {

        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int restaurantId { get; set; }

    }

}