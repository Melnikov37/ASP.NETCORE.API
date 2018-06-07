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
    [Route("api/RestOnWaterSerAtTours")]
    public class RestOnWaterSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public RestOnWaterSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/RestOnWaterSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<RestOnWaterSerAtTour> GetRestOnWaterSerAtTour([FromRoute] int id)
        {
            return _context.RestOnWaterSerAtTour.Include(h => h.RestOnWaterSer).Where(d => d.TouristDestinationId == id);
        }
        
        // PUT: api/RestOnWaterSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestOnWaterSerAtTour([FromRoute] int id, [FromBody] RestOnWaterSerAtTour restOnWaterSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != restOnWaterSerAtTour.RestOnWaterSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(restOnWaterSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestOnWaterSerAtTourExists(id))
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

        // POST: api/RestOnWaterSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostRestOnWaterSerAtTour([FromBody] RestOnWaterSerAtTour restOnWaterSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RestOnWaterSerAtTour.Add(restOnWaterSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestOnWaterSerAtTour", new { id = restOnWaterSerAtTour.RestOnWaterSerAtTourId }, restOnWaterSerAtTour);
        }

        // DELETE: api/RestOnWaterSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestOnWaterSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var restOnWaterSerAtTour = await _context.RestOnWaterSerAtTour.SingleOrDefaultAsync(m => m.RestOnWaterSerAtTourId == id);
            if (restOnWaterSerAtTour == null)
            {
                return NotFound();
            }

            _context.RestOnWaterSerAtTour.Remove(restOnWaterSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(restOnWaterSerAtTour);
        }

        private bool RestOnWaterSerAtTourExists(int id)
        {
            return _context.RestOnWaterSerAtTour.Any(e => e.RestOnWaterSerAtTourId == id);
        }
    }
}