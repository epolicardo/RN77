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
    public class DocumentosController : ControllerBase
    {
        private readonly RN77Context context;

        public DocumentosController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/Documentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Documentos>>> GetDocumentos()
        {
            return await this.context.Documentos.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/TDocumentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Documentos>> GetDocumentos(int id)
        {
            var DocumentosItem = await this.context.Documentos.FindAsync(id);

            if (DocumentosItem == null)
            {
                return this.BadRequest("No existen Documentos.");
            }

            return DocumentosItem;
        }

        // POST:/api/ Documentos
        // en body
        // {
        //     "tdocumento": "1",
        //     "documento": "38330569"
        // }
        [HttpPost]
        public async Task<IActionResult> PostDocumentos([FromBody] DocumentosRequest documentosRequest)
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

            var entity = new Documentos
            {
                TdocumentoId = documentosRequest.TdocumentoId,
                Documento = documentosRequest.Documento,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Documentos>().AddAsync(entity);
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

        // PUT: api/Documentos/32
        // en body
        // {
        //    "tdocumento": "1",
        //     "documento": "38330569"
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocumentos(int id, [FromBody] DocumentosRequest documentosRequest)
        {

            var entity = await this.context.Set<Documentos>().FindAsync(id);
            entity.Documento = documentosRequest.Documento;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Documentos/32
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocumentos(int id)
        {
            var documentos = await this.context.Documentos.FindAsync(id);

            if (documentos == null)
            {
                return this.BadRequest("Documentos no existe.");
            }

            this.context.Documentos.Remove(documentos);
            await this.context.SaveChangesAsync();

            return Ok();
        }

    }

}