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
    [Route("api/Photos")]
    public class PhotosController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public PhotosController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Photos
        [HttpGet("{id}")]
        public IEnumerable<Photos> GetPhotos([FromRoute] int id)
        {
            return _context.Photos.Where(d => d.TouristDestinationId == id);
        }

        // PUT: api/Photos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhotos([FromRoute] int id, [FromBody] Photos photos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != photos.PhotoId)
            {
                return BadRequest();
            }

            _context.Entry(photos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotosExists(id))
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

        // POST: api/Photos
        [HttpPost]
        public async Task<IActionResult> PostPhotos([FromBody] Photos photos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Photos.Add(photos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhotos", new { id = photos.PhotoId }, photos);
        }

        // DELETE: api/Photos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhotos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var photos = await _context.Photos.SingleOrDefaultAsync(m => m.PhotoId == id);
            if (photos == null)
            {
                return NotFound();
            }

            _context.Photos.Remove(photos);
            await _context.SaveChangesAsync();

            return Ok(photos);
        }

        private bool PhotosExists(int id)
        {
            return _context.Photos.Any(e => e.PhotoId == id);
        }
    }
}