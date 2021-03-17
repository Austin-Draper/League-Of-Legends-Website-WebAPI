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
    public class UniqueTagsController : ControllerBase
    {
        private readonly UniqueTagsContext _context;

        public UniqueTagsController(UniqueTagsContext context)
        {
            _context = context;
        }

        // GET: api/UniqueTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UniqueTags>>> GetUniqueTags()
        {
            return await _context.UniqueTags.ToListAsync();
        }

        
        // GET: api/UniqueTags/Email
        [HttpGet("{Email}")]
        public async Task<ActionResult<UniqueTags>> GetUniqueTags(string Email)
        {
            var uniqueTags = await _context.UniqueTags.FindAsync(Email);

            if (uniqueTags == null)
            {
                return NotFound();
            }

            return uniqueTags;
        }

        // PUT: api/UniqueTags/removeTag/Email... new put im playing around with to remove tag from ALL champions
        //[HttpPut("RemoveTagPutRoster/{removeTag}/{Email}")]
        //public async Task<IActionResult> RemoveTagPutRoster(string removeTag, string Email, UniqueTags uniqueTags)
        //{

            //return NoContent();
        //}

        // PUT: api/UniqueTags/Email
        [HttpPut("{Email}")]
        public async Task<IActionResult> PutUniqueTags(string Email, UniqueTags uniqueTags)
        {
            if (Email != uniqueTags.Email)
            {
                return BadRequest();
            }

            _context.Entry(uniqueTags).State = EntityState.Modified;
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniqueTagsExists(Email))
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

        [HttpPut("RemoveTagPutUniqueTags/{removeTag}/{Email}")]
        public async Task<IActionResult> RemoveTagPutUniqueTags(string removeTag, string Email, string Trash)
        {
            var uniqueTags = await _context.UniqueTags.FindAsync(Email);//uniqueTags holds all uniqueTags of this user

            //TODO: replace this long list of if statements with a single foreach that checks each value of uniqueTags
            //foreach( var prop in uniqueTags.GetType().GetProperties())
            //{
                //Console.WriteLine("This is working!!!!");
            //}

            if (uniqueTags.Tag1 == removeTag)
            {
                uniqueTags.Tag1 = null;
            }
            if (uniqueTags.Tag2 == removeTag)
            {
                uniqueTags.Tag2 = null;
            }
            if (uniqueTags.Tag3 == removeTag)
            {
                uniqueTags.Tag3 = null;
            }
            if (uniqueTags.Tag4 == removeTag)
            {
                uniqueTags.Tag4 = null;
            }
            if (uniqueTags.Tag5 == removeTag)
            {
                uniqueTags.Tag5 = null;
            }
            if (uniqueTags.Tag6 == removeTag)
            {
                uniqueTags.Tag6 = null;
            }
            if (uniqueTags.Tag7 == removeTag)
            {
                uniqueTags.Tag7 = null;
            }
            if (uniqueTags.Tag8 == removeTag)
            {
                uniqueTags.Tag8 = null;
            }
            if (uniqueTags.Tag9 == removeTag)
            {
                uniqueTags.Tag9 = null;
            }
            if (uniqueTags.Tag10 == removeTag)
            {
                uniqueTags.Tag10 = null;
            }
            if (uniqueTags.Tag11 == removeTag)
            {
                uniqueTags.Tag11 = null;
            }
            if (uniqueTags.Tag12 == removeTag)
            {
                uniqueTags.Tag12 = null;
            }
            if (uniqueTags.Tag13 == removeTag)
            {
                uniqueTags.Tag13 = null;
            }
            if (uniqueTags.Tag14 == removeTag)
            {
                uniqueTags.Tag14 = null;
            }
            if (uniqueTags.Tag15 == removeTag)
            {
                uniqueTags.Tag15 = null;
            }
            if (uniqueTags.Tag16 == removeTag)
            {
                uniqueTags.Tag16 = null;
            }
            if (uniqueTags.Tag17 == removeTag)
            {
                uniqueTags.Tag17 = null;
            }
            if (uniqueTags.Tag18 == removeTag)
            {
                uniqueTags.Tag18 = null;
            }
            if (uniqueTags.Tag19 == removeTag)
            {
                uniqueTags.Tag19 = null;
            }
            if (uniqueTags.Tag20 == removeTag)
            {
                uniqueTags.Tag20 = null;
            }
            if (uniqueTags.Tag21 == removeTag)
            {
                uniqueTags.Tag21 = null;
            }
            if (uniqueTags.Tag22 == removeTag)
            {
                uniqueTags.Tag22 = null;
            }
            if (uniqueTags.Tag23 == removeTag)
            {
                uniqueTags.Tag23 = null;
            }
            if (uniqueTags.Tag24 == removeTag)
            {
                uniqueTags.Tag24 = null;
            }
            if (uniqueTags.Tag25 == removeTag)
            {
                uniqueTags.Tag25 = null;
            }
            if (uniqueTags.Tag26 == removeTag)
            {
                uniqueTags.Tag26 = null;
            }
            if (uniqueTags.Tag27 == removeTag)
            {
                uniqueTags.Tag27 = null;
            }
            if (uniqueTags.Tag28 == removeTag)
            {
                uniqueTags.Tag28 = null;
            }
            if (uniqueTags.Tag29 == removeTag)
            {
                uniqueTags.Tag29 = null;
            }
            if (uniqueTags.Tag30 == removeTag)
            {
                uniqueTags.Tag30 = null;
            }

            _context.Entry(uniqueTags).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            //after this is all done, remove the tag from list of maximum 30 tags... need to keep it async

            return NoContent();
        }

        /*
        // PUT: api/UniqueTags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniqueTags(string id, UniqueTags uniqueTags)
        {
            if (id != uniqueTags.Email)
            {
                return BadRequest();
            }

            _context.Entry(uniqueTags).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniqueTagsExists(id))
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
        */


        // POST: api/UniqueTags
        [HttpPost]
        public async Task<ActionResult<UniqueTags>> PostUniqueTags(UniqueTags uniqueTags)
        {
            _context.UniqueTags.Add(uniqueTags);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniqueTags", new { id = uniqueTags.Email }, uniqueTags);
        }

        // DELETE: api/UniqueTags/5
        /*
        [HttpDelete("{id}")]
        public async Task<ActionResult<UniqueTags>> DeleteUniqueTags(string id)
        {
            var uniqueTags = await _context.UniqueTags.FindAsync(id);
            if (uniqueTags == null)
            {
                return NotFound();
            }

            _context.UniqueTags.Remove(uniqueTags);
            await _context.SaveChangesAsync();

            return uniqueTags;
        }
        */

        [HttpDelete("DeleteUniqueTags/{Email}")]
        public async Task<ActionResult<UniqueTags>> DeleteUniqueTags(string Email)
        {
            var uniqueTags = await _context.UniqueTags.FindAsync(Email);
            if (uniqueTags == null)
            {
                return NotFound();
            }

            _context.UniqueTags.Remove(uniqueTags);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool UniqueTagsExists(string id)
        {
            return _context.UniqueTags.Any(e => e.Email == id);
        }
    }
}
