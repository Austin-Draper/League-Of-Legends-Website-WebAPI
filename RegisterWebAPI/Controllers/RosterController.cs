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
    public class RosterController : ControllerBase
    {
        private readonly RosterContext _context;

        public RosterController(RosterContext context)
        {
            _context = context;
        }


        // GET: api/Roster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roster>>> GetRosterChamps()
        {
            return await _context.RosterChamps.ToListAsync();
        }

        // GET: api/Roster/5
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Roster>> GetRoster(int id)
        {
            var roster = await _context.RosterChamps.FindAsync(id);

            if (roster == null)
            {
                return NotFound();
            }

            return roster;
        }
        
        // GET: api/Roster/Email
        [HttpGet("GetTheRoster/{Email}")]
        public List<Roster> GetTheRoster(string Email)
        {
            //might need to return NotFound if _context is null
            return _context.RosterChamps.Where(v => v.Email == Email).ToList();
        }

        // PUT: api/Roster/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoster(int id, Roster roster)
        {
            if (id != roster.PMId)
            {
                return BadRequest();
            }

            _context.Entry(roster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RosterExists(id))
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


        // PUT: api/Roster/... new put im playing around with to remove tag from ALL champions
        //[HttpPut("RemoveTagPutRoster/{removeTag}/{Email}")]
        [HttpPut("RemoveTagPutRoster/{removeTag}/{Email}")]
        public async Task<IActionResult> RemoveTagPutRoster(string removeTag, string Email, string Trash)
        {
            //from the put statement in angular that calls this function
            //removeTag = tag to be removed
            //roster = body
            //Trash is a non-used value I had to use in the angular application in order to send to this function
            //Can fix Trash problem by removing Email from the URL and sending the email instead
            foreach (var roster in _context.RosterChamps.Where(v => v.Email == Email).ToList())
            {
                if (roster.Tag1 == removeTag)
                {
                    roster.Tag1 = null;
                }
                if (roster.Tag2 == removeTag)
                {
                    roster.Tag2 = null;
                }
                if (roster.Tag3 == removeTag)
                {
                    roster.Tag3 = null;
                }
                if (roster.Tag4 == removeTag)
                {
                    roster.Tag4 = null;
                }
                if (roster.Tag5 == removeTag)
                {
                    roster.Tag5 = null;
                }
                if (roster.Tag6 == removeTag)
                {
                    roster.Tag6 = null;
                }
                _context.Entry(roster).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();
            //after this is all done, remove the tag from list of maximum 30 tags... need to keep it async

            return NoContent();
        }


        // POST: api/Roster
        [HttpPost]
        public async Task<ActionResult<Roster>> PostRoster(Roster roster)
        {
            _context.RosterChamps.Add(roster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoster", new { id = roster.PMId }, roster);
        }

        // DELETE: api/Roster/5
        /*
        [HttpDelete("{id}")]
        public async Task<ActionResult<Roster>> DeleteRoster(int id)
        {
            var roster = await _context.RosterChamps.FindAsync(id);
            if (roster == null)
            {
                return NotFound();
            }

            _context.RosterChamps.Remove(roster);
            await _context.SaveChangesAsync();

            return roster;
        }
        */

            //try either of these two comments below
        // DELETE: api/Roster/Email
        // DELETE: api/Roster/DeleteRoster/{Email} 
        [HttpDelete("DeleteRoster/{Email}")]
public async Task<ActionResult<Roster>> DeleteRoster(string Email)
{
            foreach (var roster in _context.RosterChamps.Where(v => v.Email == Email).ToList())
            {

                _context.RosterChamps.Remove(roster);
                _context.Entry(roster).State = EntityState.Deleted;
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

private bool RosterExists(int id)
{
    return _context.RosterChamps.Any(e => e.PMId == id);
}
}


}
