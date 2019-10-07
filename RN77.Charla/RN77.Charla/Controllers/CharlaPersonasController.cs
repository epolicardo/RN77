using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Charla.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//Olmedo Santiago


namespace RN77.Charla.Personas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharlaPersonasController : ControllerBase
    {
        private readonly RN77Context context;
        public CharlaPersonasController(RN77Context context)
        {
            this.context = context;
        }
        // GET: api/CharlaPersona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharlaPersonas>>> GetCharlaPersonas()
        {
            return await context.CharlaPersonas.ToListAsync();
        }

        // GET api/Tcharlas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharlaPersonas>> GetCharlaPersonas(int id)
        {
            var CharlaPersonasItem = await context.CharlaPersonas.FindAsync(id);
            if (CharlaPersonasItem == null)
            {
                return this.BadRequest("No existe tal Charla");
            }
            return CharlaPersonasItem;
        }

        // POST api/Tcharlas
        [HttpPost]
        public async Task<IActionResult> PostCharlaPersonas([FromBody]CharlaPersonasRequest CharlaPersonasRequest)
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
            var entity = new CharlaPersonas
            {
                CharlaId = CharlaPersonasRequest.CharlaId,
                PersonaId = CharlaPersonasRequest.PersonaId,
            };
            BaseController.CompletaRegistro(entity, 1, "", user, false);


            await this.context.Set<CharlaPersonas>().AddAsync(entity);
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