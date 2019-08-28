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
    public class PaisesController : ControllerBase
    {
        private readonly RN77Context context;

        public PaisesController(RN77Context context)
        {
            this.context = context;


        }

        // GET: api/Paises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPaises()
        {
            return await context.Paises.ToListAsync();
        }



        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paises>> GetPaises(int id)
        {
            var paisesItem = await context.Paises.FindAsync(id);

            if (paisesItem == null)
            {
                return NotFound();
            }

            return paisesItem;
        }

        // POST: api/Paises
        [HttpPost]
        public async Task<ActionResult<Paises>> PostPaises(Paises item)
        {
            context.Paises.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPaises), new { id = item.Id }, item);
        }

        // PUT: api/Paises/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaises(int id, Paises item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaises(int id)
        {
            var paises = await context.Paises.FindAsync(id);

            if (paises == null)
            {
                return NotFound();
            }

            context.Paises.Remove(paises);
            await context.SaveChangesAsync();

            return NoContent();
        }
 
    }

}