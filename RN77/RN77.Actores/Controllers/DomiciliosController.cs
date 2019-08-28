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
    public class DomiciliosController : ControllerBase
    {
        private readonly RN77Context context;

            public DomiciliosController(RN77Context context)
            {
                this.context = context;

            
            }

        // GET: api/Domicilios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domicilios>>> GetDomicilios()
        {
            return await context.Domicilios.ToListAsync();
        }

        

        // GET: api/Domicilios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domicilios>> GetDomicilios(int id)
        {
            var domiciliosItem = await context.Domicilios.FindAsync(id);

            if (domiciliosItem == null)
            {
                return NotFound();
            }

            return domiciliosItem;
        }

        // POST: api/Domicilios
        [HttpPost]
        public async Task<ActionResult<Domicilios>> PostDomicilios(Domicilios item)
        {
            context.Domicilios.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDomicilios), new { id = item.Id }, item);
        }

        // PUT: api/Domicilios/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomicilios(int id, Domicilios item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Domicilios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomicilios(int id)
        {
            var domicilios = await context.Domicilios.FindAsync(id);

            if (domicilios == null)
            {
                return NotFound();
            }

            context.Domicilios.Remove(domicilios);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}