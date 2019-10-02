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
    public class InstitucionesController : ControllerBase
    {
        private readonly RN77Context context;

        public InstitucionesController(RN77Context context)
        {
            this.context = context;


        }

        // GET: api/Instituciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instituciones>>> GetInstituciones()
        {
            return await context.Instituciones.ToListAsync();
        }



        // GET: api/Instituciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instituciones>> GetInstituciones(int id)
        {
            var institucionesItem = await context.Instituciones.FindAsync(id);

            if (institucionesItem == null)
            {
                return NotFound();
            }

            return institucionesItem;
        }

        // POST: api/Instituciones
        [HttpPost]
        public async Task<ActionResult<Instituciones>> PostInstituciones(Instituciones item)
        {
            context.Instituciones.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInstituciones), new { id = item.Id }, item);
        }

        // PUT: api/Instituciones/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstituciones(int id, Instituciones item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Instituciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstituciones(int id)
        {
            var instituciones = await context.Instituciones.FindAsync(id);

            if (instituciones == null)
            {
                return NotFound();
            }

            context.Instituciones.Remove(instituciones);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}