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
    public class DocumentCRUDController : ControllerBase
    {
        private readonly WebbProvAPI2Context _context;

        public DocumentCRUDController(WebbProvAPI2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Document>>> GetDocuments()
        {
            return await _context.Documents.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Document>> GetDocument(long id)
        {
            var document = await _context.Documents.FindAsync(id);

            if (document == null)
            {
                return NotFound();
            }

            return document;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditDocument(long id, Document document)
        {
            if (id != document.Id)
            {
                return BadRequest();
            }

            _context.Entry(document).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentExists(id))
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
        public async Task<ActionResult<Document>> PostDocument(Document document)
        {
            _context.Documents.Add(document);
            var x = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDocument), new { id = document.Id }, document);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Document>> DeleteDocument(long id)
        {
            var document = await _context.Documents.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }

            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();

            return document;
        }

        private bool DocumentExists(long id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }
    }
}
