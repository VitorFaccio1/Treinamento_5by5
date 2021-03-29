using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Dal;
using ProjetoFinanceiro.Models;

namespace projetoFinanceiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly FinanceiroContext _context;

        public ContaCorrenteController(FinanceiroContext context)
        {
            _context = context;
        }

        // GET: api/ContaCorrente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaCorrente>>> GetContaCorrente()
        {
            return await _context.ContaCorrente.ToListAsync();
        }

        // GET: api/ContaCorrente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaCorrente>> GetContaCorrente(int id)
        {
            var contaCorrente = await _context.ContaCorrente.FindAsync(id);

            if (contaCorrente == null)
            {
                return NotFound();
            }

            return contaCorrente;
        }

        // PUT: api/ContaCorrente/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaCorrente(int id, ContaCorrente contaCorrente)
        {
            if (id != contaCorrente.Id)
            {
                return BadRequest();
            }

            _context.Entry(contaCorrente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaCorrenteExists(id))
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

        // POST: api/ContaCorrente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContaCorrente>> PostContaCorrente(ContaCorrente contaCorrente)
        {
            _context.ContaCorrente.Add(contaCorrente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContaCorrente", new { id = contaCorrente.Id }, contaCorrente);
        }

        // DELETE: api/ContaCorrente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContaCorrente(int id)
        {
            var contaCorrente = await _context.ContaCorrente.FindAsync(id);
            if (contaCorrente == null)
            {
                return NotFound();
            }

            _context.ContaCorrente.Remove(contaCorrente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaCorrenteExists(int id)
        {
            return _context.ContaCorrente.Any(e => e.Id == id);
        }
    }
}
