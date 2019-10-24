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
    public class PersonaMailsController : ControllerBase
    {
        private readonly RN77Context context;

        public PersonaMailsController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/PersonaMails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaMails>>> GetPerMails()
        {
            return await this.context.PersonaMails.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/PersonaDocumentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaMails>> GetPerMails(int id)
        {
            var personamail = await this.context.PersonaMails.FindAsync(id);

            if (personamail == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Uno o mas campos no existen.",
                    Resultado = null
                });
            }

            //return PersonaMails;
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = personamail
            });
        }

        // POST:/api/PersonaMails
        // en body
        // {
        //     "personaid": 1,
        //     "mailid": "1",
        // }
        [HttpPost]
        public async Task<IActionResult> PostPerMails([FromBody] PersonaMailsRequest personamailsRequest)
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

            var mails = await this.context.Mails.FindAsync(personamailsRequest.MailId);
            if (mails == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Mail no existe.",
                    Resultado = null
                });
            }

            var entity = new PersonaMails
            {
                Persona = persona,
                Mail = mails,
                Usuario = user
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<PersonaMails>().AddAsync(entity);
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
                Resultado = new PersonaMails
                {
                    PersonaId = entity.PersonaId,
                    MailId = entity.MailId,
                }
            });
        }

        // PUT: api/PersonaMails/5
        // en body
        // {
        //     "PersonaId": 1,
        //     "MailId": "1",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerMails(int id, [FromBody] PersonaMailsRequest personaMailsRequest)
        {

            var entity = await this.context.Set<PersonaMails>().FindAsync(id);

            var mails = await this.context.Mails.FindAsync(personaMailsRequest.MailId);
            if (mails == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "mails no existe.",
                    Resultado = null
                });
            }
            entity.Mail = mails;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new PersonaMails
                {
                    PersonaId = entity.PersonaId,
                    MailId = entity.MailId,
                }
            });
        }

        // DELETE: api/PersonaMails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerMails(int id)
        {
            var personamails = await this.context.PersonaMails.FindAsync(id);

            if (personamails == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Revisar los campos.",
                    Resultado = null
                });
            }

            this.context.PersonaMails.Remove(personamails);
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