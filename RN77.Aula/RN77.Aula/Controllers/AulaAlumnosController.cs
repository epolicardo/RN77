using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Aula.Request;
using RN77.Comun.Models.Aula.Respuesta;
using RN77.Comun.Models.Varios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RN77.Aula_A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaAlumnosController : ControllerBase
    {
        private readonly RN77Context context;

        public AulaAlumnosController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/AulaAlumnos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AulaAlumnos>>> GetAulaAlumnos()
        {
            return await this.context.AulaAlumnos.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/AulaAlumnos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AulaAlumnos>> GetAulaAlumnos(int id)
        {
            var Aulas = await this.context.AulaAlumnos.FindAsync(id);

            if (Aulas == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "No existen Provincias.",
                    Resultado = null
                });
            }

            //return AulaAlumnos;
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = Aulas
            });
        }

        // POST:/api/AulaAlumnos
        // en body
        // {
        //     "AulaId": 1,
        //     "PersonaId": "",
        // }
        [HttpPost]
        public async Task<ActionResult<Respuesta>> PostAulaAlumnos([FromBody] AulaAlumnosRequest aulaAlumnosRequest)
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

            var Aula = await this.context.AulaAlumnos.FindAsync(aulaAlumnosRequest.AulaId);
            if (Aula == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Pais no existe.",
                    Resultado = null
                });
            }

            var entity = new AulaAlumnos
            {
               AulaId = aulaAlumnosRequest.AulaId,
               PersonaId = aulaAlumnosRequest.PersonaId,
               Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<AulaAlumnos>().AddAsync(entity);
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

            //return Ok(new Respuesta
            //{
            //    EsExitoso = true,
            //    Mensaje = "",
            //    Resultado = entity
            //});

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new AulaAlumnosRespuesta
                {
                    AulaId = entity.AulaId,
                    PersonaId = entity.PersonaId,
                   
                }
            });
        }

        // PUT: api/AulaAlumnos/5
        // en body
        // {
        //     "paisId": 1,
        //     "nombreProvincia": "Córdoba",
        // }
        [HttpPut("{id}")]
        public async Task<ActionResult<Respuesta>> PutAulaAlumnos(int id, [FromBody] AulaAlumnosRequest aulaAlumnosRequest)
        {

            var entity = await this.context.Set<AulaAlumnos>().FindAsync(id);

            var Aula = await this.context.AulaAlumnos.FindAsync(aulaAlumnosRequest.AulaId);
            if (Aula == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Pais no existe.",
                    Resultado = null
                });
            }
            
            entity.AulaId = aulaAlumnosRequest.AulaId;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new AulaAlumnosRespuesta
                {
                    AulaId = entity.Id,
                    PersonaId = entity.PersonaId,
                   
                }
            });
        }

        // DELETE: api/AulaAlumnos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Respuesta>> DeleteAulaAlumnos(int id)
        {
            var Aula = await this.context.AulaAlumnos.FindAsync(id);

            if (Aula == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Provincia no existe.",
                    Resultado = null
                });
            }

            this.context.AulaAlumnos.Remove(Aula);
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