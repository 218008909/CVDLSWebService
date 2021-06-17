using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CVDLS.Data;
using CVDLS.Models;

namespace CVDLS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly CVDLSContext _context;

        public LocationsController(CVDLSContext context)
        {
            _context = context;
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        {
            return await _context.Location.ToListAsync();
        }

        // GET: api/Locations/ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(string id)
        {
            var location = await _context.Location.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        // PUT: api/Locations/ID
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(string id, Location location)
        {
            if (id != location.LocationID)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/Locations
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _context.Location.Add(location);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LocationExists(location.LocationID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLocation", new { id = location.LocationID }, location);
        }

        // DELETE: api/Locations/ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(string id)
        {
            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Location.Remove(location);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationExists(string id)
        {
            return _context.Location.Any(e => e.LocationID == id);
        }
    }
}
