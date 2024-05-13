using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HostelAPIWebApp.Models;

namespace HostelAPIWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomMaintenancesController : ControllerBase
    {
        private readonly HostelAPIContext _context;

        public RoomMaintenancesController(HostelAPIContext context)
        {
            _context = context;
        }

        // GET: api/RoomMaintenances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomMaintenance>>> GetRoomMaintenances()
        {
            return await _context.RoomMaintenances.ToListAsync();
        }

        // GET: api/RoomMaintenances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomMaintenance>> GetRoomMaintenance(int id)
        {
            var roomMaintenance = await _context.RoomMaintenances.FindAsync(id);

            if (roomMaintenance == null)
            {
                return NotFound();
            }

            return roomMaintenance;
        }

        // PUT: api/RoomMaintenances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomMaintenance(int id, RoomMaintenance roomMaintenance)
        {
            if (id != roomMaintenance.MaintenanceID)
            {
                return BadRequest();
            }

            _context.Entry(roomMaintenance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomMaintenanceExists(id))
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

        // POST: api/RoomMaintenances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoomMaintenance>> PostRoomMaintenance(RoomMaintenance roomMaintenance)
        {
            _context.RoomMaintenances.Add(roomMaintenance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoomMaintenance", new { id = roomMaintenance.MaintenanceID }, roomMaintenance);
        }

        // DELETE: api/RoomMaintenances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomMaintenance(int id)
        {
            var roomMaintenance = await _context.RoomMaintenances.FindAsync(id);
            if (roomMaintenance == null)
            {
                return NotFound();
            }

            _context.RoomMaintenances.Remove(roomMaintenance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoomMaintenanceExists(int id)
        {
            return _context.RoomMaintenances.Any(e => e.MaintenanceID == id);
        }
    }
}
