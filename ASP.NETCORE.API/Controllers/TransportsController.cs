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
    [Route("api/Transports")]
    public class TransportsController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public TransportsController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Transports
        [HttpGet]
        public IEnumerable<Transports> GetTransports()
        {
            return _context.Transports;
        }

        // GET: api/Transports/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransports([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var transports = await _context.Transports.SingleOrDefaultAsync(m => m.TransportId == id);

            if (transports == null)
            {
                return NotFound();
            }

            return Ok(transports);
        }

        // PUT: api/Transports/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransports([FromRoute] int id, [FromBody] Transports transports)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transports.TransportId)
            {
                return BadRequest();
            }

            _context.Entry(transports).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportsExists(id))
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

        // POST: api/Transports
        [HttpPost]
        public async Task<IActionResult> PostTransports([FromBody] Transports transports)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Transports.Add(transports);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransports", new { id = transports.TransportId }, transports);
        }

        // DELETE: api/Transports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransports([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var transports = await _context.Transports.SingleOrDefaultAsync(m => m.TransportId == id);
            if (transports == null)
            {
                return NotFound();
            }

            _context.Transports.Remove(transports);
            await _context.SaveChangesAsync();

            return Ok(transports);
        }

        private bool TransportsExists(int id)
        {
            return _context.Transports.Any(e => e.TransportId == id);
        }
    }
}