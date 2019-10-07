using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Persona.Request;
using RN77.Comun.Models.Varios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly RN77Context context;

        public PersonasController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/Personas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personas>>> GetPersonas()
        {
            return await this.context.Personas.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Personas
        [HttpGet("{id}")]
        public async Task<ActionResult<Personas>> GetPersonas(long id)
        {
            var personasItem = await this.context.Personas.FindAsync(id);

            if (personasItem == null)
            {
                return this.BadRequest("No existen Personas.");
            }
            return personasItem;
        }

        // POST: api/Personas
        [HttpPost]
        public async Task<IActionResult> PostPersona([FromBody] PersonaRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Petición Incorrecta",
                    Resultado = null
                });
            }

            var user = await this.context.Users.FindAsync("1");
            if (user == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Usuario Invalido",
                    Resultado = null
                });
            }

            var entity = new Personas
            {
                Nombre = peticion.Nombre,
                Apellido = peticion.Apellido,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Personas>().AddAsync(entity);
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
                Resultado = entity
            });
        }

        // PUT: api/Personas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonas(int id, [FromBody] PersonaRequest peticion)
        {            
            var entity = await this.context.Set<Personas>().FindAsync(id);
            entity.Nombre = peticion.Nombre;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = entity
            });
        }

        // DELETE: api/personas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonas(int id)
        {
            var personas = await this.context.Personas.FindAsync(id);

            if (personas == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "La persona no existe.",
                    Resultado = null
                });
            }

            this.context.Personas.Remove(personas);
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