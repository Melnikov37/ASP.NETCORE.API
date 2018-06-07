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
    [Route("api/BusinessSerAtTours")]
    public class BusinessSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public BusinessSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/BusinessSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<BusinessSerAtTour> GetBusinessSerAtTour([FromRoute] int id)
        {
            return _context.BusinessSerAtTour.Include(h => h.BusinessSer).Where(d => d.TouristDestinationId == id);
        }

        // PUT: api/BusinessSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessSerAtTour([FromRoute] int id, [FromBody] BusinessSerAtTour businessSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != businessSerAtTour.BusinessSerArTourId)
            {
                return BadRequest();
            }

            _context.Entry(businessSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessSerAtTourExists(id))
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

        // POST: api/BusinessSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostBusinessSerAtTour([FromBody] BusinessSerAtTour businessSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BusinessSerAtTour.Add(businessSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinessSerAtTour", new { id = businessSerAtTour.BusinessSerArTourId }, businessSerAtTour);
        }

        // DELETE: api/BusinessSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var businessSerAtTour = await _context.BusinessSerAtTour.SingleOrDefaultAsync(m => m.BusinessSerArTourId == id);
            if (businessSerAtTour == null)
            {
                return NotFound();
            }

            _context.BusinessSerAtTour.Remove(businessSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(businessSerAtTour);
        }

        private bool BusinessSerAtTourExists(int id)
        {
            return _context.BusinessSerAtTour.Any(e => e.BusinessSerArTourId == id);
        }
    }
}