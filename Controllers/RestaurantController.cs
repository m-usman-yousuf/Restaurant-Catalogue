using System.Collections.Generic;
using AutoMapper;
using RestaurantMenu.Data;
using RestaurantMenu.Dtos;
using RestaurantMenu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace RestaurantMenu.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/restaurants")]
    public class RestaurantController : MyControllerBase
    {
        private readonly IRestaurantRepo _repository;
        private readonly IMapper _mapper;

        public RestaurantController(IRestaurantRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;


        }

        //Get api/restaurants
        [HttpGet]
        public ActionResult<IEnumerable<RestaurantReadDto>> GetAllRestaurants()
        {
            var restaurantItems = _repository.GetAllRestaurants();
            return Ok(_mapper.Map<IEnumerable<RestaurantReadDto>>(restaurantItems));

        }

        //GET api/Restaurants/{id}
        [HttpGet("{id}", Name = "GetRestaurantbyId")]
        public ActionResult<RestaurantReadDto> GetRestaurantById(int id)
        {

            var restaurantItem = _repository.GetRestaurantById(id);
            if (restaurantItem != null)
            {
                return Ok(_mapper.Map<RestaurantReadDto>(restaurantItem));
            }
            return NotFound();

        }
        //POST api/Restaurants
        [HttpPost]
        public ActionResult<RestaurantReadDto> CreateRestaurant(RestaurantCreateDto restaurantCreateDto)
        {
            var restaurantModel = _mapper.Map<Restaurant>(restaurantCreateDto);
            _repository.CreateRestaurant(restaurantModel);
            _repository.SaveChanges();
            var restaurantReadDto = _mapper.Map<RestaurantReadDto>(restaurantModel);
            return CreatedAtRoute(nameof(GetRestaurantById), new { Id = restaurantReadDto.Id }, restaurantReadDto);
            // return Ok(RestaurantReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateRestaurant(int id, RestaurantUpdateDto restaurantUpdateDto)
        {
            var restaurantModelFromRepo = _repository.GetRestaurantById(id);
            if (restaurantModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(restaurantUpdateDto, restaurantModelFromRepo);
            _repository.UpdateRestaurant(restaurantModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        //DELETE API/Restaurants/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRestaurant(int id)
        {
            var restaurantModelFromRepo = _repository.GetRestaurantById(id);
            if (restaurantModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteRestaurant(restaurantModelFromRepo);
            _repository.SaveChanges();
            return NoContent();

        }

    }
}