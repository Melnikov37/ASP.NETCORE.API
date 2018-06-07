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
    [Route("api/InternetSerAtTours")]
    public class InternetSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public InternetSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/InternetSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<InternetSerAtTour> GetInternetSerAtTour([FromRoute] int id)
        {
            return _context.InternetSerAtTour.Include(h => h.InternetSer).Where(d => d.TouristDestinationsId == id);
        }

        // PUT: api/InternetSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInternetSerAtTour([FromRoute] int id, [FromBody] InternetSerAtTour internetSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != internetSerAtTour.InternetSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(internetSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternetSerAtTourExists(id))
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

        // POST: api/InternetSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostInternetSerAtTour([FromBody] InternetSerAtTour internetSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InternetSerAtTour.Add(internetSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInternetSerAtTour", new { id = internetSerAtTour.InternetSerAtTourId }, internetSerAtTour);
        }

        // DELETE: api/InternetSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInternetSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var internetSerAtTour = await _context.InternetSerAtTour.SingleOrDefaultAsync(m => m.InternetSerAtTourId == id);
            if (internetSerAtTour == null)
            {
                return NotFound();
            }

            _context.InternetSerAtTour.Remove(internetSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(internetSerAtTour);
        }

        private bool InternetSerAtTourExists(int id)
        {
            return _context.InternetSerAtTour.Any(e => e.InternetSerAtTourId == id);
        }
    }
}