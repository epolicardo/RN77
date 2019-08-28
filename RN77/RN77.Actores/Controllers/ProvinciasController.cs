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
    public class ProvinciasController : ControllerBase
    {
        private readonly RN77Context context;

        public ProvinciasController(RN77Context context)
        {
            this.context = context;


        }

        // GET: api/Provincias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincias>>> GetProvincias()
        {
            return await context.Provincias.ToListAsync();
        }



        // GET: api/Provincias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincias>> GetProvincias(int id)
        {
            var provinciasItem = await context.Provincias.FindAsync(id);

            if (provinciasItem == null)
            {
                return NotFound();
            }

            return provinciasItem;
        }

        // POST: api/Provincias
        [HttpPost]
        public async Task<ActionResult<Provincias>> PostProvincias(Provincias item)
        {
            context.Provincias.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProvincias), new { id = item.Id }, item);
        }

        // PUT: api/Provincias/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvincias(int id, Provincias item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Provincias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvincias(int id)
        {
            var provincias = await context.Provincias.FindAsync(id);

            if (provincias == null)
            {
                return NotFound();
            }

            context.Provincias.Remove(provincias);
            await context.SaveChangesAsync();

            return NoContent();
        }

    }
}
