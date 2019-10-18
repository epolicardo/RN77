using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Persona.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TDocumentosController : ControllerBase
    {
        private readonly RN77Context context;

        public TDocumentosController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/TDocumentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tdocumentos>>> GetTDocumentos()
        {
            return await this.context.Tdocumentos.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/TDocumentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tdocumentos>> GetTDocumentos(int id)
        {
            var TDocumentosItem = await this.context.Tdocumentos.FindAsync(id);

            if (TDocumentosItem == null)
            {
                return this.BadRequest("No existen  Tipos de Documentos.");
            }

            return TDocumentosItem;
        }

        // POST:/api/ TDocumentos
        // en body
        // {
        //     "codigo": "GA",
        //     "nombre": "Gaston",
        // }
        [HttpPost]
        public async Task<IActionResult> PostTDocumentos([FromBody] TDocumentosRequest tDocumentosRequest)
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

            var entity = new Tdocumentos
            {
                Codigo = tDocumentosRequest.Codigo,
                Nombre = tDocumentosRequest.Nombre,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Tdocumentos>().AddAsync(entity);
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

        // PUT: api/TDocumentos/32
        // en body
        // {
        //     "codigo": "GA",
        //     "nombre": "Gaston",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTDocumentos(int id, [FromBody] TDocumentosRequest tDocumentosRequest)
        {

            var entity = await this.context.Set<Tdocumentos>().FindAsync(id);
            entity.Nombre = tDocumentosRequest.Nombre;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/TDocumentos/32
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTDocumentos(int id)
        {
            var tdocumentos = await this.context.Tdocumentos.FindAsync(id);

            if (tdocumentos == null)
            {
                return this.BadRequest("Tdocumentos no existe.");
            }

            this.context.Tdocumentos.Remove(tdocumentos);
            await this.context.SaveChangesAsync();

            return Ok();
        }

    }

}
