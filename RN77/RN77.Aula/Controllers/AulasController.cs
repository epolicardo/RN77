using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.BD.Models.Domicilio;

namespace RN77.Aula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulasController : ControllerBase
    {
        private readonly RN77Context context;

        public AulasController(RN77Context context)
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
            return await this.context.Aulas.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Aulas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aulas>> GetAulas(int id)
        {
            var aulasItem = await this.context.Aulas.FindAsync(id);

            if (aulasItem == null)
            {
                return this.BadRequest("No existen Aulas.");
            }

            return aulasItem;
        }

        // POST:/api/Aulas
        // en body
        // {
        //     "CodigoAula" : "XTR233",
        //     "Nombre" : "Prgramación II",
        //     "Descripcion" : "Aula de programación II - ITSC",
        //     "AnoLectivo" : "2019",
        //     "Periodo" : "2º"
        // }
        [HttpPost]
        public async Task<IActionResult> PostAulas([FromBody] AulaViewModel aulaViewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var user = await this.context.Users.FindAsync("1");
            if (user == null)
            {
                return this.BadRequest("Usuario Invalido");
            }

            var entity = new Aulas
            {
                CodigoAula = aulaViewModel.CodigoAula,
                Nombre = aulaViewModel.Nombre,
                Descripcion = aulaViewModel.Descripcion,
                AnoLectivo = aulaViewModel.AnoLectivo,
                Periodo = aulaViewModel.Periodo,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Aulas>().AddAsync(entity);
            try
            {
                await this.context.SaveChangesAsync();
            }
            catch (Exception ee)
            {
                return this.BadRequest("Registro no grabado, controlar.");
            }

            return Ok(entity);
        }

        // PUT: api/Aulas/5
        // en body
        // {
        //     "CodigoAula" : "XTR233",
        //     "Nombre" : "Prgramación II",
        //     "Descripcion" : "Aula de programación II - ITSC",
        //     "AnoLectivo" : "2019",
        //     "Periodo" : "2º"
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAulas(int id, [FromBody] AulaViewModel aulaViewModel)
        {

            var entity = await this.context.Set<Aulas>().FindAsync(id);
            entity.Nombre = aulaViewModel.Nombre;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Aulas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAulas(int id)
        {
            var aulas = await this.context.Aulas.FindAsync(id);

            if (aulas == null)
            {
                return this.BadRequest("Aula no existe.");
            }

            this.context.Aulas.Remove(aulas);
            await this.context.SaveChangesAsync();

            return Ok();
        }


    }
}


    