using System.Collections.Generic;
using RestaurantMenu.Models;

namespace RestaurantMenu.Data
{
    public class MockRestaurantRepo : IRestaurantRepo
    {
        public void CreateRestaurant(Restaurant cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRestaurant(Restaurant cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            var restaurants = new List<Restaurant>{
                new Restaurant{Id=0,name="Boil an Egg",address="Boil Water"},
                new Restaurant{Id=1,name="cut Bread",address="Get a Knife"},
                new Restaurant{Id=2,name="make a cup of tea",address="Place teabag in cup"},
            };

            return restaurants;
        }



        public Restaurant GetRestaurantById(int id)
        {
            return new Restaurant { Id = 0, name = "Boil an Egg", address = "Boil Water" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateRestaurant(Restaurant cmd)
        {
            throw new System.NotImplementedException();
        }

    }
}