using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contrats;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntrustController : ControllerBase
    {
        private readonly IEntrustService _entrustService;

        public EntrustController(IEntrustService entrustService)
        {
            _entrustService = entrustService;
        }

        [HttpGet]
        public IActionResult GetAllEntrusts()
        {
            var entrusts = _entrustService.GetAllEntrusts(trackChanges: false);
            return Ok(entrusts);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetEntrustById(int id)
        {
            var entrust = _entrustService.GetEntrustById(id, null, trackChanges: false);
            if (entrust == null)
            {
                return NotFound("Entrust not found");
            }
            return Ok(entrust);
        }

        [HttpPost]
        public IActionResult CreateEntrust([FromBody] Entrust entrust)
        {
            if (entrust == null)
            {
                return BadRequest("Entrust is null");
            }
            _entrustService.CreateEntrust(entrust);
            return CreatedAtAction(nameof(GetEntrustById), new { id = entrust.EntrustId }, entrust);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateEntrust(int id, [FromBody] Entrust entrust)
        {
            if (entrust == null)
            {
                return BadRequest("Entrust is null");
            }
            _entrustService.UpdateEntrust(id, entrust, trackChanges: true);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEntrust(int id)
        {
            var entrust = _entrustService.GetEntrustById(id, null, trackChanges: false);
            if (entrust == null)
            {
                return NotFound("Entrust not found");
            }
            _entrustService.DeleteEntrustById(id, entrust, trackChanges: true);
            return NoContent();
        }
    }
}