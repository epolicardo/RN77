using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;

namespace RN77.Aula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly RN77Context context;

        public MateriasController(RN77Context context)
        {
            this.context = context;


        }

        // GET: api/Materias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materias>>> GetMaterias()
        {
            return await context.Materias.ToListAsync();
        }



        // GET: api/Materias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materias>> GetMaterias(int id)
        {
            var materiasItem = await context.Materias.FindAsync(id);

            if (materiasItem == null)
            {
                return NotFound();
            }

            return materiasItem;
        }

        // POST: api/Materias
        [HttpPost]
        public async Task<ActionResult<Materias>> PostCarreras(Materias item)
        {
            context.Materias.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMaterias), new { id = item.Id }, item);
        }

        // PUT: api/Materias/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterias(int id, Materias item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Materias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterias(int id)
        {
            var materias = await context.Materias.FindAsync(id);

            if (materias == null)
            {
                return NotFound();
            }

            context.Materias.Remove(materias);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}