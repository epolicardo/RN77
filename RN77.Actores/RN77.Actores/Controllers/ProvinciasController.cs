using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Domicilio.Request;
using RN77.Comun.Models.Domicilio.Respuesta;
using RN77.Comun.Models.Varios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        private readonly RN77Context context;

        public ProvinciasController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/Provincias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincias>>> GetProvincias()
        {
            return await this.context.Provincias.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Provincias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincias>> GetProvincias(int id)
        {
            var provincias = await this.context.Provincias.FindAsync(id);

            if (provincias == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "No existen Provincias.",
                    Resultado = null
                });
            }

            //return provincias;
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = provincias
            });
        }

        // POST:/api/Provincias
        // en body
        // {
        //     "paisId": 1,
        //     "nombreProvincia": "Córdoba",
        // }
        [HttpPost]
        public async Task<ActionResult<Respuesta>> PostProvincias([FromBody] ProvinciaRequest provinciaRequest)
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

            var pais = await this.context.Paises.FindAsync(provinciaRequest.PaisId);
            if (pais == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Pais no existe.",
                    Resultado = null
                });
            }

            var entity = new Provincias
            {
                NombreProvincia = provinciaRequest.NombreProvincia,
                Pais = pais,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Provincias>().AddAsync(entity);
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
                Resultado = new ProvinciaRespuesta
                {
                    ProvinciaId = entity.Id,
                    PaisId = entity.PaisId,
                    NombrePais = entity.Pais.NombrePais,
                    NombreProvincia = entity.NombreProvincia
                }
            });
        }

        // PUT: api/Provincias/5
        // en body
        // {
        //     "paisId": 1,
        //     "nombreProvincia": "Córdoba",
        // }
        [HttpPut("{id}")]
        public async Task<ActionResult<Respuesta>> PutProvincias(int id, [FromBody] ProvinciaRequest provinciaRequest)
        {

            var entity = await this.context.Set<Provincias>().FindAsync(id);

            var pais = await this.context.Paises.FindAsync(provinciaRequest.PaisId);
            if (pais == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Pais no existe.",
                    Resultado = null
                });
            }
            entity.Pais = pais;
            entity.NombreProvincia = provinciaRequest.NombreProvincia;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = new ProvinciaRespuesta
                {
                    ProvinciaId = entity.Id,
                    PaisId = entity.PaisId,
                    NombrePais = entity.Pais.NombrePais,
                    NombreProvincia = entity.NombreProvincia
                }
            });
        }

        // DELETE: api/Provincias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Respuesta>> DeleteProvincias(int id)
        {
            var provincias = await this.context.Provincias.FindAsync(id);

            if (provincias == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Provincia no existe.",
                    Resultado = null
                });
            }

            this.context.Provincias.Remove(provincias);
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