using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
    public class PageCRUDController : ControllerBase
    {
        private readonly WebbProvAPI2Context _context;

        public PageCRUDController(WebbProvAPI2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreatedPage>>> GetCreatedPages()
        {
            return await _context.CreatedPages.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CreatedPage>> GetCreatedPage(long id)
        {
            var cPage = await _context.CreatedPages.FindAsync(id);

            if (cPage == null)
            {
                return NotFound();
            }

            return cPage;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCreatedPage(long id, CreatedPage cPage)
        {
            if (id != cPage.Id)
            {
                return BadRequest();
            }

            _context.Entry(cPage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreatedPageExists(id))
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
        public async Task<ActionResult<CreatedPage>> PostCreatedPage(CreatedPage createdPage)
        {
            _context.CreatedPages.Add(createdPage);
            var x = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCreatedPage), new { id = createdPage.Id }, createdPage);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CreatedPage>> DeleteCreatedPage(long id)
        {
            var cPage = await _context.CreatedPages.FindAsync(id);
            if (cPage == null)
            {
                return NotFound();
            }

            _context.CreatedPages.Remove(cPage);
            await _context.SaveChangesAsync();

            return cPage;
        }

        private bool CreatedPageExists(long id)
        {
            return _context.CreatedPages.Any(e => e.Id == id);
        }

    }
}
