using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contrats;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            var items = _itemService.GetAllItems(trackChanges: false);
            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItemById(int id)
        {
            var item = _itemService.GetItemById(id, trackChanges: false);
            if (item == null)
            {
                return NotFound("Item not found");
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem([FromBody] Item item)
        {
            if (item == null)
            {
                return BadRequest("Item is null");
            }
            _itemService.CreateItem(item);
            return CreatedAtAction(nameof(GetItemById), new { id = item.ItemId }, item);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateItem(int id, [FromBody] Item item)
        {
            if (item == null)
            {
                return BadRequest("Item is null");
            }
            _itemService.UpdateItem(item);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _itemService.GetItemById(id, trackChanges: false);
            if (item == null)
            {
                return NotFound("Item not found");
            }
            _itemService.DeleteItemById(item);
            return NoContent();
        }
    }
}