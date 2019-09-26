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
    public class AsistenciasController : ControllerBase
    {
        private readonly RN77Context _context;

        public AsistenciasController(RN77Context context)
        {
            _context = context;
        }

        // GET: api/Asistencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AulaAsistencias>>> GetAulaAsistencias()
        {
            return await _context.AulaAsistencias.ToListAsync();
        }

        // GET: api/Asistencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AulaAsistencias>> GetAulaAsistencias(int id)
        {
            var aulaAsistencias = await _context.AulaAsistencias.FindAsync(id);

            if (aulaAsistencias == null)
            {
                return NotFound();
            }

            return aulaAsistencias;
        }

        // PUT: api/Asistencias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAulaAsistencias(int id, AulaAsistencias aulaAsistencias)
        {
            if (id != aulaAsistencias.Id)
            {
                return BadRequest();
            }

            _context.Entry(aulaAsistencias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AulaAsistenciasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Asistencias
        [HttpPost]
        public async Task<ActionResult<AulaAsistencias>> PostAulaAsistencias(AulaAsistencias aulaAsistencias)
        {
            _context.AulaAsistencias.Add(aulaAsistencias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAulaAsistencias", new { id = aulaAsistencias.Id }, aulaAsistencias);
        }

        // DELETE: api/Asistencias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AulaAsistencias>> DeleteAulaAsistencias(int id)
        {
            var aulaAsistencias = await _context.AulaAsistencias.FindAsync(id);
            if (aulaAsistencias == null)
            {
                return NotFound();
            }

            _context.AulaAsistencias.Remove(aulaAsistencias);
            await _context.SaveChangesAsync();

            return aulaAsistencias;
        }

        private bool AulaAsistenciasExists(int id)
        {
            return _context.AulaAsistencias.Any(e => e.Id == id);
        }
    }
}
