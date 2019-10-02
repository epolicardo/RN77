using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TdomiciliosController : ControllerBase
    {
        private readonly RN77Context context;

        public TdomiciliosController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/Tdomicilios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tdomicilios>>> GetTDomicilios()
        {
            return await context.Tdomicilios.ToListAsync();
        }

        // GET: api/Tdomicilios/5

        [HttpGet("{id}")]
        public async Task<ActionResult<Tdomicilios>> GetTdomicilios(int id)
        {
            var tdomiciliosItem = await context.Tdomicilios.FindAsync(id);

            if (tdomiciliosItem == null)
            {
                return NotFound();

            }

            return tdomiciliosItem;
        }

        // POST: api/Tdomicilios
        [HttpPost]
        public async Task<ActionResult<Tdomicilios>> PostTdomicilios(Tdomicilios item)
        {
            context.Tdomicilios.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTdomicilios), new { id = item.Id }, item);
        }

        // PUT: api/Tdomicilios/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PuTdDomicilios(int id, Tdomicilios item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Tdomicilios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdomicilios(int id)
        {
            var tdomicilios = await context.Tdomicilios.FindAsync(id);

            if (tdomicilios == null)
            {
                return NotFound();
            }

            context.Tdomicilios.Remove(tdomicilios);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}