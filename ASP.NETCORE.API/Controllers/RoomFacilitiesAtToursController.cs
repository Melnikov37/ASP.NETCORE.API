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
    [Route("api/RoomFacilitiesAtTours")]
    public class RoomFacilitiesAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public RoomFacilitiesAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/RoomFacilitiesAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<RoomFacilitiesAtTour> GetRoomFacilitiesAtTour([FromRoute] int id)
        {
            return _context.RoomFacilitiesAtTour.Include(h => h.RoomFacilities).Where(d => d.TouristDestinationsId == id);
        }

        // PUT: api/RoomFacilitiesAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomFacilitiesAtTour([FromRoute] int id, [FromBody] RoomFacilitiesAtTour roomFacilitiesAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != roomFacilitiesAtTour.RoomFacilitiesAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(roomFacilitiesAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomFacilitiesAtTourExists(id))
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

        // POST: api/RoomFacilitiesAtTours
        [HttpPost]
        public async Task<IActionResult> PostRoomFacilitiesAtTour([FromBody] RoomFacilitiesAtTour roomFacilitiesAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RoomFacilitiesAtTour.Add(roomFacilitiesAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoomFacilitiesAtTour", new { id = roomFacilitiesAtTour.RoomFacilitiesAtTourId }, roomFacilitiesAtTour);
        }

        // DELETE: api/RoomFacilitiesAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomFacilitiesAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roomFacilitiesAtTour = await _context.RoomFacilitiesAtTour.SingleOrDefaultAsync(m => m.RoomFacilitiesAtTourId == id);
            if (roomFacilitiesAtTour == null)
            {
                return NotFound();
            }

            _context.RoomFacilitiesAtTour.Remove(roomFacilitiesAtTour);
            await _context.SaveChangesAsync();

            return Ok(roomFacilitiesAtTour);
        }

        private bool RoomFacilitiesAtTourExists(int id)
        {
            return _context.RoomFacilitiesAtTour.Any(e => e.RoomFacilitiesAtTourId == id);
        }
    }
}