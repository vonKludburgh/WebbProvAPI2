using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbProvAPI2.Data;
using WebbProvAPI2.Models;

namespace WebbProvAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherArticleCRUDController : ControllerBase
    {
        private readonly WebbProvAPI2Context _context;

        public OtherArticleCRUDController(WebbProvAPI2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OtherArticle>>> GetOtherArticles()
        {
            return await _context.OtherArticles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OtherArticle>> GetOtherArticle(long id)
        {
            var otherarticle = await _context.OtherArticles.FindAsync(id);

            if (otherarticle == null)
            {
                return NotFound();
            }

            return otherarticle;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditOtherArticle(long id, OtherArticle otherarticle)
        {
            if (id != otherarticle.Id)
            {
                return BadRequest();
            }

            _context.Entry(otherarticle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OtherArticleExists(id))
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
        public async Task<ActionResult<OtherArticle>> PostOtherArticle(OtherArticle otherarticle)
        {
            _context.OtherArticles.Add(otherarticle);
            var x = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOtherArticles), new { id = otherarticle.Id }, otherarticle);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OtherArticle>> DeleteOtherArticle(long id)
        {
            var otherarticle = await _context.OtherArticles.FindAsync(id);
            if (otherarticle == null)
            {
                return NotFound();
            }

            _context.OtherArticles.Remove(otherarticle);
            await _context.SaveChangesAsync();

            return otherarticle;
        }

        private bool OtherArticleExists(long id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }
    }
}
