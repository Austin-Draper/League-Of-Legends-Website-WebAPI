using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegisterWebAPI.Models;

namespace RegisterWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticChampController : ControllerBase
    {
        private readonly StaticChampContext _context;

        public StaticChampController(StaticChampContext context)
        {
            _context = context;
        }

        // GET: api/StaticChamp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaticChamp>>> GetStaticChamps()
        {
            return await _context.StaticChamps.ToListAsync();
        }

        // GET: api/StaticChamp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaticChamp>> GetStaticChamp(int id)
        {
            var staticChamp = await _context.StaticChamps.FindAsync(id);

            if (staticChamp == null)
            {
                return NotFound();
            }

            return staticChamp;
        }

        // PUT: api/StaticChamp/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaticChamp(int id, StaticChamp staticChamp)
        {
            if (id != staticChamp.PMId)
            {
                return BadRequest();
            }

            _context.Entry(staticChamp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaticChampExists(id))
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

        // POST: api/StaticChamp
        [HttpPost]
        public async Task<ActionResult<StaticChamp>> PostStaticChamp(StaticChamp staticChamp)
        {
            _context.StaticChamps.Add(staticChamp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaticChamp", new { id = staticChamp.PMId }, staticChamp);
        }

        // DELETE: api/StaticChamp/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StaticChamp>> DeleteStaticChamp(int id)
        {
            var staticChamp = await _context.StaticChamps.FindAsync(id);
            if (staticChamp == null)
            {
                return NotFound();
            }

            _context.StaticChamps.Remove(staticChamp);
            await _context.SaveChangesAsync();

            return staticChamp;
        }

        private bool StaticChampExists(int id)
        {
            return _context.StaticChamps.Any(e => e.PMId == id);
        }
    }
}
