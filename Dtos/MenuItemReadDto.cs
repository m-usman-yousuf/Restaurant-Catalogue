using System.ComponentModel.DataAnnotations;

namespace RestaurantMenu.Dtos
{
    public class MenuItemReadDto
    {
        public int Id { get; set; }

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