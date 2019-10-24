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
    public class PersonaDomiciliosController : ControllerBase
    {
        private readonly RN77Context context;

        public PersonaDomiciliosController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/PersonaDomicilios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDomicilios>>> GetPerDom()
        {
            return await this.context.PersonaDomicilios.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/PersonaDomicilios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaDomicilios>> GetPerDom(int id)
        {
            var personadom = await this.context.PersonaDomicilios.FindAsync(id);

            if (personadom == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Uno o mas campos no existen.",
                    Resultado = null
                });
            }

            //return PersonaDomicilios;
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = personadom
            });
        }

        // POST:/api/PersonaDocumentos
        // en body
        // {
        //     "personaid": 1,
        //     "documentoid": "1",
        // }
        [HttpPost]
        public async Task<IActionResult> PostPerDom([FromBody] PersonaDomiciliosRequest personadomiciliosRequest)
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

            var domicilios = await this.context.Domicilios.FindAsync(personadomiciliosRequest.DomicilioId);
            if (domicilios == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Domicilios no existe.",
                    Resultado = null
                });
            }

            var entity = new PersonaDomicilios
            {
                Persona = persona,
                Domicilio = domicilios,
                Usuario = user
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<PersonaDomicilios>().AddAsync(entity);
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
                Resultado = new PersonaDomicilios
                {
                    PersonaId = entity.PersonaId,
                    DomicilioId = entity.DomicilioId,
                }
            });
        }

        // PUT: api/PersonaDomicilio/5
        // en body
        // {
        //     "PersonaId": 1,
        //     "DomicilioId": "1",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerDom(int id, [FromBody] PersonaDomiciliosRequest personadomiciliosRequest)
        {

            var entity = await this.context.Set<PersonaDomicilios>().FindAsync(id);

            var domicilios = await this.context.Domicilios.FindAsync(personadomiciliosRequest.DomicilioId);
            if (domicilios == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Domicilio no existe.",
                    Resultado = null
                });
            }
            entity.Domicilio = domicilios;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new PersonaDomicilios
                {
                    PersonaId = entity.PersonaId,
                    DomicilioId = entity.DomicilioId,
                }
            });
        }

        // DELETE: api/PersonaDomicilio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerDom(int id)
        {
            var personadomicilios = await this.context.PersonaDomicilios.FindAsync(id);

            if (personadomicilios == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Revisar los campos.",
                    Resultado = null
                });
            }

            this.context.PersonaDomicilios.Remove(personadomicilios);
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

