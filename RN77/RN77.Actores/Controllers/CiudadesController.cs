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
    public class CiudadesController : ControllerBase
    {
        private readonly RN77Context context;

        public CiudadesController(RN77Context context)
        {
            this.context = context;

        }

        // GET: api/Ciudades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudades>>> GetCiudades()
        {
            return await context.Ciudades.ToListAsync();
        }



        // GET: api/Ciudades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudades>> GetCiudades(int id)
        {
            var ciudadesItem = await context.Ciudades.FindAsync(id);

            if (ciudadesItem == null)
            {
                return NotFound();
            }

            return ciudadesItem;
        }

        // POST: api/Ciudades
        [HttpPost]
        public async Task<ActionResult<Paises>> PostCiudades(Ciudades item)
        {
            context.Ciudades.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCiudades), new { id = item.Id }, item);
        }

        // PUT: api/Ciudades/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudades(int id, Ciudades item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Ciudades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudades(int id)
        {
            var ciudades = await context.Ciudades.FindAsync(id);

            if (ciudades == null)
            {
                return NotFound();
            }

            context.Ciudades.Remove(ciudades);
            await context.SaveChangesAsync();

            return NoContent();
        }

    }
}
