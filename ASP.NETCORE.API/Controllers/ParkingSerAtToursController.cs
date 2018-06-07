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
    [Route("api/ParkingSerAtTours")]
    public class ParkingSerAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public ParkingSerAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/ParkingSerAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<ParkingSerAtTour> GetParkingSerAtTour([FromRoute] int id)
        {
            return _context.ParkingSerAtTour.Include(h => h.ParkingSer).Where(d => d.TouristDestinationsId == id);
        }

        // PUT: api/ParkingSerAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParkingSerAtTour([FromRoute] int id, [FromBody] ParkingSerAtTour parkingSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != parkingSerAtTour.ParkingSerAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(parkingSerAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParkingSerAtTourExists(id))
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

        // POST: api/ParkingSerAtTours
        [HttpPost]
        public async Task<IActionResult> PostParkingSerAtTour([FromBody] ParkingSerAtTour parkingSerAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ParkingSerAtTour.Add(parkingSerAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParkingSerAtTour", new { id = parkingSerAtTour.ParkingSerAtTourId }, parkingSerAtTour);
        }

        // DELETE: api/ParkingSerAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParkingSerAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parkingSerAtTour = await _context.ParkingSerAtTour.SingleOrDefaultAsync(m => m.ParkingSerAtTourId == id);
            if (parkingSerAtTour == null)
            {
                return NotFound();
            }

            _context.ParkingSerAtTour.Remove(parkingSerAtTour);
            await _context.SaveChangesAsync();

            return Ok(parkingSerAtTour);
        }

        private bool ParkingSerAtTourExists(int id)
        {
            return _context.ParkingSerAtTour.Any(e => e.ParkingSerAtTourId == id);
        }
    }
}