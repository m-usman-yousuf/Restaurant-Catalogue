using AutoMapper;
using RestaurantMenu.Dtos;
using RestaurantMenu.Models;

namespace RestaurantMenu.Profiles
{

    public class RestaurantProfile : Profile
    {
        public RestaurantProfile()
        {
            //source-> Target
            CreateMap<Restaurant, RestaurantReadDto>();
            CreateMap<RestaurantCreateDto, Restaurant>();
            CreateMap<RestaurantUpdateDto, Restaurant>();
        }

    }
}