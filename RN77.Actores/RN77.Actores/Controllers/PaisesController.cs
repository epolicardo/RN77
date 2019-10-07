using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.Comun.Models.Domicilio.Request;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly RN77Context context;

        public PaisesController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/Paises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPaises()
        {
            return await this.context.Paises.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paises>> GetPaises(int id)
        {
            var paisesItem = await this.context.Paises.FindAsync(id);

            if (paisesItem == null)
            {
                return this.BadRequest("No existen Paises.");
            }

            return paisesItem;
        }

        // POST:/api/Paises
        // en body
        // {
        //     "codigoPais": "PE",
        //     "nombrePais": "Peru",
        // }
        [HttpPost]
        public async Task<IActionResult> PostPaises([FromBody] PaisRequest paisRequest)
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

            var entity = new Paises
            {
                CodigoPais = paisRequest.CodigoPais,
                NombrePais = paisRequest.NombrePais,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Paises>().AddAsync(entity);
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

        // PUT: api/Paises/5
        // en body
        // {
        //     "codigoPais": "PE",
        //     "nombrePais": "Peru",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaises(int id, [FromBody] PaisRequest paisRequest)
        {

            var entity = await this.context.Set<Paises>().FindAsync(id);
            entity.NombrePais = paisRequest.NombrePais;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaises(int id)
        {
            var paises = await this.context.Paises.FindAsync(id);

            if (paises == null)
            {
                return this.BadRequest("Pais no existe.");
            }

            this.context.Paises.Remove(paises);
            await this.context.SaveChangesAsync();

            return Ok();
        }
 
    }

}