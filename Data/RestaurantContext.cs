using RestaurantMenu.Models;
using Microsoft.EntityFrameworkCore;

namespace RestaurantMenu.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> opt) : base(opt)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
    // public class MenuItemContext : DbContext
    //  {
    //   public MenuItemContext(DbContextOptions<MenuItemContext> opt) : base(opt)
    // {

    //}
    //public DbSet<MenuItem> MenuItems { get; set; }
    //}
}