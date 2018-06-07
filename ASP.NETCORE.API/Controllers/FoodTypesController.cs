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
    [Route("api/FoodTypes")]
    public class FoodTypesController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public FoodTypesController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/FoodTypes
        [HttpGet]
        public IEnumerable<FoodType> GetFoodType()
        {
            return _context.FoodType;
        }

        // GET: api/FoodTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foodType = await _context.FoodType.SingleOrDefaultAsync(m => m.FoodTypeId == id);

            if (foodType == null)
            {
                return NotFound();
            }

            return Ok(foodType);
        }

        // PUT: api/FoodTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodType([FromRoute] int id, [FromBody] FoodType foodType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != foodType.FoodTypeId)
            {
                return BadRequest();
            }

            _context.Entry(foodType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodTypeExists(id))
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

        // POST: api/FoodTypes
        [HttpPost]
        public async Task<IActionResult> PostFoodType([FromBody] FoodType foodType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FoodType.Add(foodType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodType", new { id = foodType.FoodTypeId }, foodType);
        }

        // DELETE: api/FoodTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foodType = await _context.FoodType.SingleOrDefaultAsync(m => m.FoodTypeId == id);
            if (foodType == null)
            {
                return NotFound();
            }

            _context.FoodType.Remove(foodType);
            await _context.SaveChangesAsync();

            return Ok(foodType);
        }

        private bool FoodTypeExists(int id)
        {
            return _context.FoodType.Any(e => e.FoodTypeId == id);
        }
    }
}