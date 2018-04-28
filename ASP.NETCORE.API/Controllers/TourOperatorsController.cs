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
    [Route("api/TourOperators")]
    public class TourOperatorsController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public TourOperatorsController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/TourOperators
        [HttpGet]
        public IEnumerable<TourOperators> GetTourOperators()
        {
            return _context.TourOperators;
        }

        // GET: api/TourOperators/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTourOperators([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tourOperators = await _context.TourOperators.SingleOrDefaultAsync(m => m.TourOperatorId == id);

            if (tourOperators == null)
            {
                return NotFound();
            }

            return Ok(tourOperators);
        }

        // PUT: api/TourOperators/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTourOperators([FromRoute] int id, [FromBody] TourOperators tourOperators)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tourOperators.TourOperatorId)
            {
                return BadRequest();
            }

            _context.Entry(tourOperators).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourOperatorsExists(id))
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

        // POST: api/TourOperators
        [HttpPost]
        public async Task<IActionResult> PostTourOperators([FromBody] TourOperators tourOperators)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TourOperators.Add(tourOperators);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTourOperators", new { id = tourOperators.TourOperatorId }, tourOperators);
        }

        // DELETE: api/TourOperators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTourOperators([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tourOperators = await _context.TourOperators.SingleOrDefaultAsync(m => m.TourOperatorId == id);
            if (tourOperators == null)
            {
                return NotFound();
            }

            _context.TourOperators.Remove(tourOperators);
            await _context.SaveChangesAsync();

            return Ok(tourOperators);
        }

        private bool TourOperatorsExists(int id)
        {
            return _context.TourOperators.Any(e => e.TourOperatorId == id);
        }
    }
}