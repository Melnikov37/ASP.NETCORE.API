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
    [Route("api/Deals")]
    public class DealsController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public DealsController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Deals
        [HttpGet]
        public IEnumerable<Deals> GetDeals()
        {
            return _context.Deals
                .Include(d => d.Tour)
                .ThenInclude(t => t.TouristDestination)
                .Include(d=>d.Condition)
                .Include(d => d.Tour)
                .ThenInclude(t => t.TouristDestination)
                .ThenInclude(td => td.PlaceDestination);
        }

        // GET: api/Deals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeals([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deals = await _context.Deals.SingleOrDefaultAsync(m => m.DealId == id);

            if (deals == null)
            {
                return NotFound();
            }

            return Ok(deals);
        }

        // PUT: api/Deals/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeals([FromRoute] int id, [FromBody] Deals deals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deals.DealId)
            {
                return BadRequest();
            }

            _context.Entry(deals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DealsExists(id))
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

        // POST: api/Deals
        [HttpPost]
        public async Task<IActionResult> PostDeals([FromBody] Deals deals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Deals.Add(deals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeals", new { id = deals.DealId }, deals);
        }

        // DELETE: api/Deals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeals([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deals = await _context.Deals.SingleOrDefaultAsync(m => m.DealId == id);
            if (deals == null)
            {
                return NotFound();
            }

            _context.Deals.Remove(deals);
            await _context.SaveChangesAsync();

            return Ok(deals);
        }

        private bool DealsExists(int id)
        {
            return _context.Deals.Any(e => e.DealId == id);
        }
    }
}