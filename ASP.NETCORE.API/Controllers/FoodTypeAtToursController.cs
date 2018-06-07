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
    [Route("api/FoodTypeAtTours")]
    public class FoodTypeAtToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public FoodTypeAtToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/FoodTypeAtTours/5
        [HttpGet("{id}")]
        public IEnumerable<FoodTypeAtTour> GetFoodTypeAtTour([FromRoute] int id)
        {
            return _context.FoodTypeAtTour.Include(h => h.FoodType).Where(d => d.TouristDestinationId == id);
        }
        
        // PUT: api/FoodTypeAtTours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodTypeAtTour([FromRoute] int id, [FromBody] FoodTypeAtTour foodTypeAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != foodTypeAtTour.FoodTypeAtTourId)
            {
                return BadRequest();
            }

            _context.Entry(foodTypeAtTour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodTypeAtTourExists(id))
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

        // POST: api/FoodTypeAtTours
        [HttpPost]
        public async Task<IActionResult> PostFoodTypeAtTour([FromBody] FoodTypeAtTour foodTypeAtTour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FoodTypeAtTour.Add(foodTypeAtTour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodTypeAtTour", new { id = foodTypeAtTour.FoodTypeAtTourId }, foodTypeAtTour);
        }

        // DELETE: api/FoodTypeAtTours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodTypeAtTour([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foodTypeAtTour = await _context.FoodTypeAtTour.SingleOrDefaultAsync(m => m.FoodTypeAtTourId == id);
            if (foodTypeAtTour == null)
            {
                return NotFound();
            }

            _context.FoodTypeAtTour.Remove(foodTypeAtTour);
            await _context.SaveChangesAsync();

            return Ok(foodTypeAtTour);
        }

        private bool FoodTypeAtTourExists(int id)
        {
            return _context.FoodTypeAtTour.Any(e => e.FoodTypeAtTourId == id);
        }
    }
}