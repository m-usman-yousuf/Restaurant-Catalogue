using System.ComponentModel.DataAnnotations;

namespace RestaurantMenu.Dtos
{
    public class MenuItemUpdateDto
    {

        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }
        [Required]
        public string price { get; set; }
        [Required]
        public int restaurantId { get; set; }

    }

}