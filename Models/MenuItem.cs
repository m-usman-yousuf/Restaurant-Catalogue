namespace RestaurantMenu.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }

        public int restaurantId { get; set; }

    }
}
