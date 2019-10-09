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
//{"esExitoso":false,"mensaje":"Usuario Invalido","resultado":null}

namespace RN77.Charla.Controllers
{
    [Route("api/[controller]")]
    public class CharlaDigosController : ControllerBase
    {
        private readonly RN77Context context;
        public CharlaDigosController(RN77Context context)
        {
            this.context = context;
        }
        // GET: api/CharlaDigos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharlaDigos>>> GetCharlaDigos()
        {
            return await context.CharlaDigos.ToListAsync();
        }

        // GET api/CharlaDigos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharlaDigos>> GetCharlaDigos(int id)
        {
            var CharlaDigosItem = await this.context.CharlaDigos.FindAsync(id);

            if (CharlaDigosItem == null)
            {
                return this.BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "No existe la charla",
                    Resultado = null
                });
            }
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = CharlaDigosItem
            });
        }

        // POST api/Tcharlas
        [HttpPost]
        public async Task<IActionResult> PostCharlaDigos([FromBody]CharlaDigosRequest CharlaDigosRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Modelo incorecto",
                    Resultado = ModelState
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
            var CharlaDigos = await this.context.CharlaDigos.FindAsync(CharlaDigosRequest.CharlaId);
            if (CharlaDigos == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Charla no existe.",
                    Resultado = null
                });
            }
            var entity = new CharlaDigos
            {
                Digo = CharlaDigosRequest.Digo
            };
            BaseController.CompletaRegistro(entity, 1, "", user, false);


            await this.context.Set<CharlaDigos>().AddAsync(entity);
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
                Resultado = new CharlaDigosRespuesta
                {
                    CharlaId=entity.CharlaId,
                    CharlaPersonaId=entity.CharlaPersonaId,
                    CharlaDigoDeDigoId=entity.CharlaDigoDeDigoId,
                    FechaDigo=entity.FechaDigo,
                    Digo=entity.Digo
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
