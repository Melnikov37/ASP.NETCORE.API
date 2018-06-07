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
    [Route("api/SportSerAtTours")]
    public class SportSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public SportSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/SportSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<SportSerAtTour> GetSportSerAtTour([FromRoute] int id)
        {
            return _context.SportSerAtTour.Include(h => h.SportSer).Where(d => d.TouristDestinationsId == id);
        }

        // PUT: api/SportSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSportSerAtTour([FromRoute] int id, [FromBody] SportSerAtTour sportSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sportSerAtTour.SportSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(sportSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SportSerAtTourExists(id))
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

        // POST: api/SportSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostSportSerAtTour([FromBody] SportSerAtTour sportSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SportSerAtTour.Add(sportSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSportSerAtTour", new { id = sportSerAtTour.SportSerAtTourId }, sportSerAtTour);
        }

        // DELETE: api/SportSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSportSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sportSerAtTour = await _context.SportSerAtTour.SingleOrDefaultAsync(m => m.SportSerAtTourId == id);
            if (sportSerAtTour == null)
            {
                return NotFound();
            }

            _context.SportSerAtTour.Remove(sportSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(sportSerAtTour);
        }

        private bool SportSerAtTourExists(int id)
        {
            return _context.SportSerAtTour.Any(e => e.SportSerAtTourId == id);
        }
    }
}