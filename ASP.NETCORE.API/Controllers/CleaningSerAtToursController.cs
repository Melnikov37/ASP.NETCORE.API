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
    [Route("api/CleaningSerAtTours")]
    public class CleaningSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public CleaningSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/CleaningSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<CleaningSerAtTour> GetCleaningSerAtTour([FromRoute] int id)
        {
            return _context.CleaningSerAtTour.Include(h => h.CleaningSer).Where(d => d.TouristDestinationId == id);
        }
        
        // PUT: api/CleaningSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCleaningSerAtTour([FromRoute] int id, [FromBody] CleaningSerAtTour cleaningSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cleaningSerAtTour.CleaningSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(cleaningSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CleaningSerAtTourExists(id))
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

        // POST: api/CleaningSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostCleaningSerAtTour([FromBody] CleaningSerAtTour cleaningSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CleaningSerAtTour.Add(cleaningSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCleaningSerAtTour", new { id = cleaningSerAtTour.CleaningSerAtTourId }, cleaningSerAtTour);
        }

        // DELETE: api/CleaningSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCleaningSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cleaningSerAtTour = await _context.CleaningSerAtTour.SingleOrDefaultAsync(m => m.CleaningSerAtTourId == id);
            if (cleaningSerAtTour == null)
            {
                return NotFound();
            }

            _context.CleaningSerAtTour.Remove(cleaningSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(cleaningSerAtTour);
        }

        private bool CleaningSerAtTourExists(int id)
        {
            return _context.CleaningSerAtTour.Any(e => e.CleaningSerAtTourId == id);
        }
    }
}