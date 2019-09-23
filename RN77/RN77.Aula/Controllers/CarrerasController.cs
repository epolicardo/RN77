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
    public class CarrerasController : ControllerBase
    {
        private readonly RN77Context context;

        public CarrerasController(RN77Context context)
        {
            this.context = context;


        }

        // GET: api/Carreras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carreras>>> GetCarreras()
        {
            return await context.Carreras.ToListAsync();
        }



        // GET: api/Carreras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carreras>> GetCarreras(int id)
        {
            var carrerasItem = await context.Carreras.FindAsync(id);

            if (carrerasItem == null)
            {
                return NotFound();
            }

            return carrerasItem;
        }

        // POST: api/Carreras
        [HttpPost]
        public async Task<ActionResult<Carreras>> PostCarreras(Carreras item)
        {
            context.Carreras.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCarreras), new { id = item.Id }, item);
        }

        // PUT: api/Carreras/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarreras(int id, Carreras item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Carreras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarreras(int id)
        {
            var carreras = await context.Carreras.FindAsync(id);

            if (carreras == null)
            {
                return NotFound();
            }

            context.Carreras.Remove(carreras);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}