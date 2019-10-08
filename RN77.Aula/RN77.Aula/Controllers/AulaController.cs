using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Aula.Request;

namespace RN77.Aula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        private readonly RN77Context context;

        public AulaController(RN77Context context)
        {
            this.context = context;

          /*
           *if (_context.Aulas.Count() == 0)
            {
                // Create a new Aula if collection is empty,
                // which means you can't delete all NotaItems.
                _context.Aulas.Add(new Aulas { CodigoAula = "XFG1234", Nombre = "Programación", AnoLectivo = 2019, Descripcion = "Aula de programación", Periodo = "1er Semestre" });
                _context.Aulas.Add(new Aulas { CodigoAula = "XFG1235", Nombre = "Matematica", AnoLectivo = 2019, Descripcion = "Aula de programación", Periodo = "1er Semestre" });
                _context.Aulas.Add(new Aulas { CodigoAula = "XFG1236", Nombre = "Base de Datos", AnoLectivo = 2019, Descripcion = "Aula de programación", Periodo = "1er Semestre" });
                _context.SaveChanges();
            }
            */
        }
        // GET: api/Aulas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aulas>>> GetAulas()
        {
            return await context.Aulas.ToListAsync();
        }

        // GET: api/Aulas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aulas>> GetAulas(int id)
        {
            var aulasItem = await context.Aulas.FindAsync(id);

            if (aulasItem == null)
            {
                return NotFound();
            }

            return aulasItem;
        }

        // POST: api/Aulas
        [HttpPost]
        public async Task<ActionResult<Aulas>> PostAulas(Aulas item)
        {
            context.Aulas.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAulas), new { id = item.Id }, item);
        }

        // PUT: api/Aulas/5
        //Verificar put en postman, no pude hacer funcionar.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, Aulas item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Aulas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAulas(int id)
        {
            var aulas = await context.Aulas.FindAsync(id);

            if (aulas == null)
            {
                return NotFound();
            }

            context.Aulas.Remove(aulas);
            await context.SaveChangesAsync();

            return NoContent();
        }


    }
}


    