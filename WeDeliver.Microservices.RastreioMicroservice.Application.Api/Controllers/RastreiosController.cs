using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel;
using WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Contexts;

namespace WeDeliver.Microservices.RastreioMicroservice.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RastreiosController : ControllerBase
    {
        private readonly RastreioContext _context;

        public RastreiosController(RastreioContext context)
        {
            _context = context;
        }

        // GET: api/Rastreios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rastreio>>> GetRastreios()
        {
            return await _context.Rastreios.ToListAsync();
        }

        // GET: api/Rastreios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rastreio>> GetRastreio(Guid id)
        {
            var rastreio = await _context.Rastreios.FindAsync(id);

            if (rastreio == null)
            {
                return NotFound();
            }

            return rastreio;
        }

        // PUT: api/Rastreios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRastreio(Guid id, Rastreio rastreio)
        {
            if (id != rastreio.Id)
            {
                return BadRequest();
            }

            _context.Entry(rastreio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RastreioExists(id))
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

        // POST: api/Rastreios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rastreio>> PostRastreio(Rastreio rastreio)
        {
            _context.Rastreios.Add(rastreio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRastreio", new { id = rastreio.Id }, rastreio);
        }

        // DELETE: api/Rastreios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rastreio>> DeleteRastreio(Guid id)
        {
            var rastreio = await _context.Rastreios.FindAsync(id);
            if (rastreio == null)
            {
                return NotFound();
            }

            _context.Rastreios.Remove(rastreio);
            await _context.SaveChangesAsync();

            return rastreio;
        }

        private bool RastreioExists(Guid id)
        {
            return _context.Rastreios.Any(e => e.Id == id);
        }
    }
}
