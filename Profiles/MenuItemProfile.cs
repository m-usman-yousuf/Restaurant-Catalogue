using AutoMapper;
using RestaurantMenu.Dtos;
using RestaurantMenu.Models;

namespace RestaurantMenu.Profiles
{

    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            //source-> Target
            CreateMap<MenuItem, MenuItemReadDto>();
            CreateMap<MenuItemCreateDto, MenuItem>();
            CreateMap<MenuItemUpdateDto, MenuItem>();
        }

    }
}