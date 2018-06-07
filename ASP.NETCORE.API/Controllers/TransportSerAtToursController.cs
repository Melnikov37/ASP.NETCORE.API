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
    [Route("api/TransportSerAtTours")]
    public class TransportSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public TransportSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/TransportSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<TransportSerAtTour> GetTransportSerAtTour([FromRoute] int id)
        {
            return _context.TransportSerAtTour.Include(h => h.TransportSer).Where(d => d.TouristDestinationsId == id);
        }

        // PUT: api/TransportSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransportSerAtTour([FromRoute] int id, [FromBody] TransportSerAtTour transportSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transportSerAtTour.TransportSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(transportSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportSerAtTourExists(id))
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

        // POST: api/TransportSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostTransportSerAtTour([FromBody] TransportSerAtTour transportSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TransportSerAtTour.Add(transportSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransportSerAtTour", new { id = transportSerAtTour.TransportSerAtTourId }, transportSerAtTour);
        }

        // DELETE: api/TransportSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransportSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var transportSerAtTour = await _context.TransportSerAtTour.SingleOrDefaultAsync(m => m.TransportSerAtTourId == id);
            if (transportSerAtTour == null)
            {
                return NotFound();
            }

            _context.TransportSerAtTour.Remove(transportSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(transportSerAtTour);
        }

        private bool TransportSerAtTourExists(int id)
        {
            return _context.TransportSerAtTour.Any(e => e.TransportSerAtTourId == id);
        }
    }
}