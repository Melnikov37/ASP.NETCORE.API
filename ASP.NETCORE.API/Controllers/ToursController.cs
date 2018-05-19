﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NETCORE.API.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP.NETCORE.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Tours")]
    public class ToursController : Controller
    {
        private readonly TravelAgencyDataBaseContext _context;

        public ToursController(TravelAgencyDataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Tours
        [HttpGet]
        public IEnumerable<Tours> GetTours()
        {
            return _context.Tours;
        }

        // GET: api/Tours/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTours([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tours = await _context.Tours.SingleOrDefaultAsync(m => m.TourId == id);

            if (tours == null)
            {
                return NotFound();
            }

            return Ok(tours);
        }

        // PUT: api/Tours/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTours([FromRoute] int id, [FromBody] Tours tours)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tours.TourId)
            {
                return BadRequest();
            }

            _context.Entry(tours).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToursExists(id))
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

        // POST: api/Tours
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostTours([FromBody] Tours tours)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tours.Add(tours);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTours", new { id = tours.TourId }, tours);
        }

        // DELETE: api/Tours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTours([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tours = await _context.Tours.SingleOrDefaultAsync(m => m.TourId == id);
            if (tours == null)
            {
                return NotFound();
            }

            _context.Tours.Remove(tours);
            await _context.SaveChangesAsync();

            return Ok(tours);
        }

        private bool ToursExists(int id)
        {
            return _context.Tours.Any(e => e.TourId == id);
        }
    }
}