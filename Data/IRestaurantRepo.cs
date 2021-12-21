using System.Collections.Generic;
using RestaurantMenu.Models;


namespace RestaurantMenu.Data
{
    public interface IRestaurantRepo
    {
        bool SaveChanges();
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(int id);
        void CreateRestaurant(Restaurant cmd);
        void UpdateRestaurant(Restaurant cmd);
        void DeleteRestaurant(Restaurant cmd);


    }
}