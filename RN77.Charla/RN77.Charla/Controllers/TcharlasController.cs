﻿using Microsoft.AspNetCore.Mvc;
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

//Agustin Giuliani
//{"esExitoso":false,"mensaje":"Usuario Invalido","resultado":null}
namespace RN77.Charla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TcharlasController : ControllerBase
    {
        private readonly RN77Context context;
        public TcharlasController(RN77Context context)
        {
            this.context = context;
        }
        // GET: api/Tcharlas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcharlas>>> GetTcharlas()
        {
            return await context.Tcharlas.ToListAsync();
        }

        // GET api/Tcharlas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcharlas>> GetTcharlas(int id)
        {
            var TcharlaItem = await context.Tcharlas.FindAsync(id);
            if (TcharlaItem == null)
            {
                return this.BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "No existe este Tipo de charla",
                    Resultado = null
                });
            }
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = TcharlaItem
            });
        }

        // POST api/Tcharlas
        [HttpPost]
        public async Task<IActionResult> PostTcharlas([FromBody]TcharlasRequest TcharlasRequest)
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
            var Tcharlas = await this.context.Charlas.FindAsync(TcharlasRequest.Codigo);
            if (Tcharlas == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Charla no existe.",
                    Resultado = null
                });
            }
            var entity = new Tcharlas
            {
                Codigo = TcharlasRequest.Codigo,
                Nombre = TcharlasRequest.Nombre,
                Descripcion = TcharlasRequest.Descripcion,
            };
            BaseController.CompletaRegistro(entity, 1, "", user, false);


            await this.context.Set<Tcharlas>().AddAsync(entity);
            try
            {
                await this.context.SaveChangesAsync();
            }
            catch (Exception)
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
                Resultado = new TcharlasRespuesta
                {
                    Nombre = entity.Nombre,
                    Descripcion = entity.Descripcion,
                    Codigo = entity.Codigo

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
