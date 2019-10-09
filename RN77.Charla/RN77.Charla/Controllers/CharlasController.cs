using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Charla.Request;
using RN77.Comun.Models.Charla.Respuesta;
using RN77.Comun.Models.Varios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Agustin Giuliani

//{"type":"https://tools.ietf.org/html/rfc7231#section-6.5.1","title":"One or more validation errors occurred.","status":400,"traceId":"|8e13d648-42fc767a4ab17ecc.","errors":{"$.Id":["The JSON value could not be converted to System.Int32. Path: $.Id | LineNumber: 1 | BytePositionInLine: 9."]}}

namespace RN77.Charla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharlasController : ControllerBase
    {
        private readonly RN77Context context;
        public CharlasController(RN77Context context)
        {
            this.context = context;
        }
        // GET: api/Charlas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Charlas>>> GetCharlas()
        {
            return await context.Charlas.ToListAsync();
        }
        // GET api/Charlas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Charlas>> GetCharlas(int id)
        {
            var CharlaItem = await this.context.Charlas.FindAsync(id);
            
            if (CharlaItem == null)
            {
                return this.BadRequest(new Respuesta
                {
                    EsExitoso=false,
                    Mensaje="No existe la charla",
                    Resultado=null
                });
            }
            return Ok(new Respuesta 
            {
                EsExitoso=true,
                Mensaje="",
                Resultado=CharlaItem
            });
        }

        // POST api/Tcharlas
        [HttpPost]
        public async Task<IActionResult> PostCharlas([FromBody]CharlasRequest CharlasRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta 
                {
                    EsExitoso=false,
                    Mensaje="Modelo incorecto",
                    Resultado=ModelState
                });
            }

            var user = await this.context.Users.FindAsync("1");
            if (user == null)
            {
                return BadRequest(new Respuesta 
                { 
                    EsExitoso=false,
                    Mensaje="Usuario Invalido",
                    Resultado=null
                });
            }
            var Charlas = await this.context.Charlas.FindAsync(CharlasRequest.Id);
            if (Charlas==null) 
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso=false,
                    Mensaje="Charla no existe.",
                    Resultado=null
                });
            }
            var entity = new Charlas
            {
                Nombre = CharlasRequest.Nombre,
                PathLogo= CharlasRequest.Pathlogo,
                Usuario = user,
                Descripcion = CharlasRequest.Descripcion,
            };
            BaseController.CompletaRegistro(entity, 1, "", user, false);


            await this.context.Set<Charlas>().AddAsync(entity);
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
                EsExitoso=true,
                Mensaje="",
                Resultado= new CharlasRespuesta 
                {
                    TcharlaId=entity.TcharlaId,
                    Id=entity.Id,
                    Nombre=entity.Nombre,
                    Descripcion=entity.Descripcion,
                    Pathlogo=entity.PathLogo

                }
            });
        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
