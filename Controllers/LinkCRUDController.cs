using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbProvAPI.Models;
using WebbProvAPI2.Data;

namespace WebbProvAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkCRUDController : ControllerBase
    {
        private readonly WebbProvAPI2Context _context;

        public LinkCRUDController(WebbProvAPI2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Link>>> GetLinks()
        {
            return await _context.Links.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Link>> GetLink(long id)
        {
            var link = await _context.Links.FindAsync(id);

            if (link == null)
            {
                return NotFound();
            }

            return link;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditLink(long id, Link link)
        {
            if (id != link.Id)
            {
                return BadRequest();
            }

            _context.Entry(link).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinkExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Link>> PostLink(Link link)
        {
            _context.Links.Add(link);
            var x = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLink), new { id = link.Id }, link);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Link>> DeleteLink(long id)
        {
            var link = await _context.Links.FindAsync(id);
            if (link == null)
            {
                return NotFound();
            }

            _context.Links.Remove(link);
            await _context.SaveChangesAsync();

            return link;
        }

        private bool LinkExists(long id)
        {
            return _context.Links.Any(e => e.Id == id);
        }
    }
}
