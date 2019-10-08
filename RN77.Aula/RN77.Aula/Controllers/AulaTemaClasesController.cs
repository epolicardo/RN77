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
using RN77.Comun.Models.Aula.Request;

namespace RN77.Aula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaTemaClasesController : ControllerBase
    {
        private readonly RN77Context context;

        public AulaTemaClasesController(RN77Context context)
        {
            this.context = context;

           
        }
        // GET: api/Aulas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AulaTemaClases>>> GetuAulaTemaClases()
        {
            return await this.context.AulaTemaClases.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Aulas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AulaTemaClases>> GetAulaTemaClases(int id)
        {
            var aulasItem = await this.context.AulaTemaClases.FindAsync(id);

            if (aulasItem == null)
            {
                return this.BadRequest("No existe tema de clases.");
            }

            return aulasItem;
        }

        // POST:/api/AulaTemaClases
        // en body
        // {
        //     "CodigoAula" : "XTR233",
        //     "Nombre" : "Prgramación II",
        //     "Descripcion" : "Aula de programación II - ITSC",
        //     "AnoLectivo" : "2019",
        //     "Periodo" : "2º"
        // }
        [HttpPost]
        public async Task<IActionResult> PostAulaTemaClases([FromBody] AulaTemaClasesRequest aulatemaclasesRequest)
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

            var entity = new AulaTemaClases
            {
                AulaId = aulatemaclasesRequest.AulaId,
                NumUnidad = aulatemaclasesRequest.NumUnidad,
                Unidad = aulatemaclasesRequest.Unidad,
                Fecha = aulatemaclasesRequest.Fecha,
                TipoClase = aulatemaclasesRequest.TipoClase,
                Contenido = aulatemaclasesRequest.Contenido,
                Actividades = aulatemaclasesRequest.Actividades,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<AulaTemaClases>().AddAsync(entity);
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

        // PUT: api/AulaTemaClases/5
        // en body
        // {
        //     "CodigoAula" : "XTR233",
        //     "Nombre" : "Prgramación II",
        //     "Descripcion" : "Aula de programación II - ITSC",
        //     "AnoLectivo" : "2019",
        //     "Periodo" : "2º"
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAulaTemaClases(int id, [FromBody] AulaTemaClasesRequest aulatemaclasesRequest)
        {

            var entity = await this.context.Set<AulaTemaClases>().FindAsync(id);
            entity.Unidad = aulatemaclasesRequest.Unidad;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Aulas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAulaTemaClases(int id)
        {
            var aulas = await this.context.AulaTemaClases.FindAsync(id);

            if (aulas == null)
            {
                return this.BadRequest("Aula no existe.");
            }

            this.context.AulaTemaClases.Remove(aulas);
            await this.context.SaveChangesAsync();

            return Ok();
        }


    }
}


