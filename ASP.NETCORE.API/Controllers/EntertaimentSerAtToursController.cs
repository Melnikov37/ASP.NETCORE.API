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
    [Route("api/EntertaimentSerAtTours")]
    public class EntertaimentSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public EntertaimentSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/EntertaimentSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<EntertaimentSerAtTour> GetEntertaimentSerAtTour([FromRoute] int id)
        {
            return _context.EntertaimentSerAtTour.Include(h => h.EntertaimentSer).Where(d => d.TouristDestinationId == id);
        }
        
        // PUT: api/EntertaimentSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntertaimentSerAtTour([FromRoute] int id, [FromBody] EntertaimentSerAtTour entertaimentSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entertaimentSerAtTour.EntertaimentSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(entertaimentSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntertaimentSerAtTourExists(id))
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

        // POST: api/EntertaimentSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostEntertaimentSerAtTour([FromBody] EntertaimentSerAtTour entertaimentSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EntertaimentSerAtTour.Add(entertaimentSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntertaimentSerAtTour", new { id = entertaimentSerAtTour.EntertaimentSerAtTourId }, entertaimentSerAtTour);
        }

        // DELETE: api/EntertaimentSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntertaimentSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entertaimentSerAtTour = await _context.EntertaimentSerAtTour.SingleOrDefaultAsync(m => m.EntertaimentSerAtTourId == id);
            if (entertaimentSerAtTour == null)
            {
                return NotFound();
            }

            _context.EntertaimentSerAtTour.Remove(entertaimentSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(entertaimentSerAtTour);
        }

        private bool EntertaimentSerAtTourExists(int id)
        {
            return _context.EntertaimentSerAtTour.Any(e => e.EntertaimentSerAtTourId == id);
        }
    }
}