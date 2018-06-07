using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NETCORE.API.Models;

namespace ASP.NETCORE.API.Controllers
{
    [Produces("application/json")]
    [Route("api/TouristDestinations")]
    public class TouristDestinationsController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public TouristDestinationsController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/TouristDestinations
        [HttpGet]
        public IEnumerable<TouristDestinations> GetTouristDestinations()
        {
            return _context.TouristDestinations.Include(p => p.PlaceDestination);
        }

        // GET: api/TouristDestinations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTouristDestinations([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var touristDestinations = await _context.TouristDestinations.SingleOrDefaultAsync(m => m.TouristDestinationId == id);

            if (touristDestinations == null)
            {
                return NotFound();
            }

            return Ok(touristDestinations);
        }

        // PUT: api/TouristDestinations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTouristDestinations([FromRoute] int id, [FromBody] TouristDestinations touristDestinations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != touristDestinations.TouristDestinationId)
            {
                return BadRequest();
            }

            _context.Entry(touristDestinations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TouristDestinationsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TouristDestinations
        [HttpPost]
        public async Task<IActionResult> PostTouristDestinations([FromBody] TouristDestinations touristDestinations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TouristDestinations.Add(touristDestinations);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTouristDestinations", new { id = touristDestinations.TouristDestinationId }, touristDestinations);
        }

        // DELETE: api/TouristDestinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTouristDestinations([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var touristDestinations = await _context.TouristDestinations.SingleOrDefaultAsync(m => m.TouristDestinationId == id);
            if (touristDestinations == null)
            {
                return NotFound();
            }

            _context.TouristDestinations.Remove(touristDestinations);
            await _context.SaveChangesAsync();

            return Ok(touristDestinations);
        }

        private bool TouristDestinationsExists(int id)
        {
            return _context.TouristDestinations.Any(e => e.TouristDestinationId == id);
        }
    }
}