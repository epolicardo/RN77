using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos.Entities;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TomarAsistenciaController : ControllerBase
    {
        private readonly BD.Datos.RN77Context context;
        private ActionResult<AulaAsistencias> AulaAsistenciasItem;

        public Paises AulaAsistencia { get; private set; }

        public TomarAsistenciaController(RN77Context context)
        {
            this.context = context;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AulaAsistencias>>> GetAulaAsistencia()
        {
            return await context.AulaAsistencias.ToListAsync();



        }

        public async Task<ActionResult<AulaAsistencias>> GetAulaAsistencia(int id)
        {
            var AulaAsistenciaItem = await context.Paises.FindAsync(id);

            if (AulaAsistenciaItem == null)
            {
                return NotFound();
            }

           return AulaAsistenciasItem;
        }

        //POST API ASISTENCIA
        [HttpPost]
        public async Task<ActionResult<AulaAsistencias>> PostPaises(AulaAsistencias item)
        {
            context.AulaAsistencias.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAulaAsistencia), new { id = item.Id }, item);
        }
        //PUT API ASISTENCIA

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAulaAsistencias(int id, AulaAsistencias item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        //delete api asistencias
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAulaAsistencias(int id)
        {
            var AulaAsistencia = await context.AulaAsistencias.FindAsync(id);

            if (AulaAsistencia == null)
            {
                return NotFound();
            }

            context.Paises.Remove(this.AulaAsistencia);
            await context.SaveChangesAsync();

            return NoContent();
        }


    }
}
