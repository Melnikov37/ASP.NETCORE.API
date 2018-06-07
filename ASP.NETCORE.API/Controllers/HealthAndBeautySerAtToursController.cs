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
    [Route("api/HealthAndBeautySerAtTours")]
    public class HealthAndBeautySerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public HealthAndBeautySerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/HealthAndBeautySerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<HealthAndBeautySerAtTour> GetHealthAndBeautySerAtTour([FromRoute] int id)
        {
            return _context.HealthAndBeautySerAtTour.Include(h => h.HealthAndBeautySer).Where(d => d.TouristDestinationId == id);
        }

        // PUT: api/HealthAndBeautySerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHealthAndBeautySerAtTour([FromRoute] int id, [FromBody] HealthAndBeautySerAtTour healthAndBeautySerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != healthAndBeautySerAtTour.HealthAndBeautySerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(healthAndBeautySerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HealthAndBeautySerAtTourExists(id))
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

        // POST: api/HealthAndBeautySerAtTours
        [HttpPost]
        public async Task<IActionResult> PostHealthAndBeautySerAtTour([FromBody] HealthAndBeautySerAtTour healthAndBeautySerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HealthAndBeautySerAtTour.Add(healthAndBeautySerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHealthAndBeautySerAtTour", new { id = healthAndBeautySerAtTour.HealthAndBeautySerAtTourId }, healthAndBeautySerAtTour);
        }

        // DELETE: api/HealthAndBeautySerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHealthAndBeautySerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var healthAndBeautySerAtTour = await _context.HealthAndBeautySerAtTour.SingleOrDefaultAsync(m => m.HealthAndBeautySerAtTourId == id);
            if (healthAndBeautySerAtTour == null)
            {
                return NotFound();
            }

            _context.HealthAndBeautySerAtTour.Remove(healthAndBeautySerAtTour);
            await _context.SaveChangesAsync();

            return Ok(healthAndBeautySerAtTour);
        }

        private bool HealthAndBeautySerAtTourExists(int id)
        {
            return _context.HealthAndBeautySerAtTour.Any(e => e.HealthAndBeautySerAtTourId == id);
        }
    }
}