using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantMenu.Models;
namespace RestaurantMenu.Data
{
    public class SqlMenuItemRepo : IMenuItemRepo
    {
        private readonly RestaurantContext _context;

        public SqlMenuItemRepo(RestaurantContext context)
        {
            _context = context;
        }

        public void CreateMenuItem(MenuItem rst)
        {
            if (rst == null)
            {
                throw new ArgumentNullException(nameof(rst));
            }
            _context.MenuItems.Add(rst);
        }

        public void DeleteMenuItem(MenuItem rst)
        {
            if (rst == null)
            {
                throw new ArgumentNullException(nameof(rst));
            }
            _context.MenuItems.Remove(rst);
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _context.MenuItems.ToList();

        }





        public MenuItem GetMenuItemById(int id)
        {
            return _context.MenuItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateMenuItem(MenuItem cmd)
        {
            //Nothing
        }

        MenuItem IMenuItemRepo.GetMenuItemById(int id)
        {
            throw new NotImplementedException();
        }
    }

}