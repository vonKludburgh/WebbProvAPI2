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
    public class ImageCRUDController : ControllerBase
    {
        private readonly WebbProvAPI2Context _context;

        public ImageCRUDController(WebbProvAPI2Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Image>>> GetImages()
        {
            return await _context.Images.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImage(long id)
        {
            var image = await _context.Images.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return image;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditImage(long id, Image image)
        {
            if (id != image.Id)
            {
                return BadRequest();
            }

            _context.Entry(image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageExists(id))
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
        public async Task<ActionResult<Image>> PostImage(Image image)
        {
            _context.Images.Add(image);
            var x = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetImage), new { id = image.Id }, image);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Image>> DeleteImage(long id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _context.Images.Remove(image);
            await _context.SaveChangesAsync();

            return image;
        }

        private bool ImageExists(long id)
        {
            return _context.Images.Any(e => e.Id == id);
        }
    }
}
