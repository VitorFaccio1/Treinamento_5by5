using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoPendencia.Api.Models;

namespace ProjetoPendencia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PendenciaController : ControllerBase
    {
        private readonly PendenciaContext _context;

        public PendenciaController(PendenciaContext context)
        {
            _context = context;
        }

        // GET: api/Pendencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pendencia>>> GetPendencia()
        {
            return await _context.Pendencia.ToListAsync();
        }

        // GET: api/Pendencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pendencia>> GetPendencia(int id)
        {
            var pendencia = await _context.Pendencia.FindAsync(id);

            if (pendencia == null)
            {
                return NotFound();
            }

            return pendencia;
        }

        // PUT: api/Pendencia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Pendencia>> PutPendencia(int id, Pendencia pendencia)
        {
            if (id != pendencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(pendencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PendenciaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return await _context.Pendencia.FindAsync(pendencia.Id);
        }

        // POST: api/Pendencia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pendencia>> PostPendencia(Pendencia pendencia)
        {
            _context.Pendencia.Add(pendencia);
            await _context.SaveChangesAsync();

            return await _context.Pendencia.FindAsync(pendencia.Id);
        }

        // DELETE: api/Pendencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pendencia>> DeletePendencia(int id)
        {
            var pendencia = await _context.Pendencia.FindAsync(id);
            if (pendencia == null)
            {
                return NotFound();
            }

            _context.Pendencia.Remove(pendencia);
            await _context.SaveChangesAsync();

            return await _context.Pendencia.FindAsync(pendencia.Id);
        }

        private bool PendenciaExists(int id)
        {
            return _context.Pendencia.Any(e => e.Id == id);
        }
    }
}
