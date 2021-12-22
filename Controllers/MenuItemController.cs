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
    [Route("api/menuItems")]
    public class MenuItemController : MyControllerBase
    {
        private readonly IMenuItemRepo _repository;
        private readonly IMapper _mapper;

        public MenuItemController(IMenuItemRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;


        }

        //Get api/menuitems
        [HttpGet]
        public ActionResult<IEnumerable<MenuItemReadDto>> GetAllMenuItems()
        {
            var MenuItems = _repository.GetAllMenuItems();
            return Ok(_mapper.Map<IEnumerable<MenuItemReadDto>>(MenuItems));

        }
        //GET api/Restaurants/{id}
        [HttpGet("{id}", Name = "GetMenuItembyId")]
        public ActionResult<MenuItemReadDto> GetMenuItemById(int id)
        {

            var MenuItemItem = _repository.GetMenuItemById(id);
            if (MenuItemItem != null)
            {
                return Ok(_mapper.Map<MenuItemReadDto>(MenuItemItem));
            }
            return NotFound();

        }
        //POST api/Restaurants
        [HttpPost]
        public ActionResult<MenuItemReadDto> CreateMenuItem(MenuItemCreateDto MenuItemCreateDto)
        {
            var MenuItemModel = _mapper.Map<MenuItem>(MenuItemCreateDto);
            _repository.CreateMenuItem(MenuItemModel);
            _repository.SaveChanges();
            var MenuItemReadDto = _mapper.Map<MenuItemReadDto>(MenuItemModel);
            return CreatedAtRoute(nameof(GetMenuItemById), new { Id = MenuItemReadDto.Id }, MenuItemReadDto);
            // return Ok(RestaurantReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateMenuItem(int id, MenuItemUpdateDto MenuItemUpdateDto)
        {
            var MenuItemModelFromRepo = _repository.GetMenuItemById(id);
            if (MenuItemModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(MenuItemUpdateDto, MenuItemModelFromRepo);
            _repository.UpdateMenuItem(MenuItemModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        //DELETE API/Restaurants/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMenuItem(int id)
        {
            var MenuItemModelFromRepo = _repository.GetMenuItemById(id);
            if (MenuItemModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteMenuItem(MenuItemModelFromRepo);
            _repository.SaveChanges();
            return NoContent();

        }

    }
}