using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Persona.Request;
using RN77.Comun.Models.Persona.Respuesta;
using RN77.Comun.Models.Varios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaDocumentosController : ControllerBase
    {
        private readonly RN77Context context;

        public PersonaDocumentosController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/PersonaDocumentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDocumentos>>> GetPerDoc()
        {
            return await this.context.PersonaDocumentos.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/PersonaDocumentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaDocumentos>> GetPerDoc(int id)
        {
            var personadoc = await this.context.PersonaDocumentos.FindAsync(id);

            if (personadoc == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Uno o mas campos no existen.",
                    Resultado = null
                });
            }

            //return PersonaDocumentos;
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = personadoc
            });
        }

        // POST:/api/PersonaDocumentos
        // en body
        // {
        //     "personaid": 1,
        //     "documentoid": "1",
        // }
        [HttpPost]
        public async Task<IActionResult> PostPerDoc([FromBody] PersonaDocumentosRequest personadocumentosRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Modelo incorrecto.",
                    Resultado = ModelState
                });
            }

            var user = await this.context.Users.FindAsync("1");
            if (user == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Usuario Invalido.",
                    Resultado = null
                });
            }

            var persona = await this.context.Personas.FindAsync(1);
            if (persona == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Persona Invalida.",
                    Resultado = null
                });
            }

            var documentos = await this.context.Documentos.FindAsync(personadocumentosRequest.DocumentoId);
            if (documentos == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Documento no existe.",
                    Resultado = null
                });
            }

            var entity = new PersonaDocumentos
            {
                Persona = persona,
                Documento = documentos,
                Usuario = user
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<PersonaDocumentos>().AddAsync(entity);
            try
            {
                await this.context.SaveChangesAsync();
            }
            catch (Exception ee)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Registro no grabado, controlar.",
                    Resultado = null
                });
            }

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new PersonaDocumentos
                {               
                    PersonaId=entity.PersonaId,
                    DocumentoId=entity.DocumentoId,                
                }
            });
        }

        // PUT: api/PersonaDocumentos/5
        // en body
        // {
        //     "PersonaId": 1,
        //     "DocumentoId": "1",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerDoc(int id, [FromBody] PersonaDocumentosRequest personadocumentosRequest)
        {

            var entity = await this.context.Set<PersonaDocumentos>().FindAsync(id);

            var documentos = await this.context.Documentos.FindAsync(personadocumentosRequest.DocumentoId);
            if (documentos == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Documento no existe.",
                    Resultado = null
                });
            }
            entity.Documento = documentos;           
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new PersonaDocumentos
                {
                    PersonaId=entity.PersonaId,
                    DocumentoId=entity.DocumentoId,   
                }
            });
        }

        // DELETE: api/PersonaDocumentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerDoc(int id)
        {
            var personadocumentos = await this.context.PersonaDocumentos.FindAsync(id);

            if (personadocumentos == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Revisar los campos.",
                    Resultado = null
                });
            }

            this.context.PersonaDocumentos.Remove(personadocumentos);
            await this.context.SaveChangesAsync();


            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = null
            });
        }
    }
}