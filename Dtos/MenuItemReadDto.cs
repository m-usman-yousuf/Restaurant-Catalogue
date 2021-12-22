

namespace RestaurantMenu.Dtos
{
    public class MenuItemReadDto
    {
        public int Id { get; set; }


        public string name { get; set; }


        public string description { get; set; }

        public string price { get; set; }
        public int restaurantId { get; set; }

    }

}