using System.Collections.Generic;
using RestaurantMenu.Models;


namespace RestaurantMenu.Data
{
    public interface IMenuItemRepo
    {
        bool SaveChanges();
        IEnumerable<MenuItem> GetAllMenuItems();
        MenuItem GetMenuItemById(int id);
        void CreateMenuItem(MenuItem cmd);
        void UpdateMenuItem(MenuItem cmd);
        void DeleteMenuItem(MenuItem cmd);


    }
}