using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HogwartsAPI.Models;

namespace HogwartsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspirantesController : ControllerBase
    {
        private readonly HogwartsAPIContext _context;

        public AspirantesController(HogwartsAPIContext context)
        {
            _context = context;
        }

        // GET: api/Aspirantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aspirantes>>> GetAspirantes()
        {
            return await _context.Aspirantes.ToListAsync();
        }

        // GET: api/Aspirantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aspirantes>> GetAspirantes(int id)
        {
            var aspirantes = await _context.Aspirantes.FindAsync(id);

            if (aspirantes == null)
            {
                return NotFound();
            }

            return aspirantes;
        }

        // PUT: api/Aspirantes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspirantes(int id, Aspirantes aspirantes)
        {
            if (id != aspirantes.Id)
            {
                return BadRequest();
            }

            _context.Entry(aspirantes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspirantesExists(id))
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

        // POST: api/Aspirantes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Aspirantes>> PostAspirantes(Aspirantes aspirantes)
        {
            _context.Aspirantes.Add(aspirantes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAspirantes", new { id = aspirantes.Id }, aspirantes);
        }

        // DELETE: api/Aspirantes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Aspirantes>> DeleteAspirantes(int id)
        {
            var aspirantes = await _context.Aspirantes.FindAsync(id);
            if (aspirantes == null)
            {
                return NotFound();
            }

            _context.Aspirantes.Remove(aspirantes);
            await _context.SaveChangesAsync();

            return aspirantes;
        }

        private bool AspirantesExists(int id)
        {
            return _context.Aspirantes.Any(e => e.Id == id);
        }
    }
}
