using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantMenu.Models;
namespace RestaurantMenu.Data
{
    public class SqlRestaurantRepo : IRestaurantRepo
    {
        private readonly RestaurantContext _context;

        public SqlRestaurantRepo(RestaurantContext context)
        {
            _context = context;
        }

        public void CreateRestaurant(Restaurant rst)
        {
            if (rst == null)
            {
                throw new ArgumentNullException(nameof(rst));
            }
            _context.Restaurants.Add(rst);
        }

        public void DeleteRestaurant(Restaurant rst)
        {
            if (rst == null)
            {
                throw new ArgumentNullException(nameof(rst));
            }
            _context.Restaurants.Remove(rst);
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.ToList();

        }





        public Restaurant GetRestaurantById(int id)
        {
            return _context.Restaurants.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateRestaurant(Restaurant cmd)
        {
            //Nothing
        }
    }

}