using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Charla.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Agustin Giuliani

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
            var CharlaItem = await context.Charlas.FindAsync(id);
            if (CharlaItem == null)
            {
                return this.BadRequest("No existe tal Charla");
            }
            return CharlaItem;
        }

        // POST api/Tcharlas
        [HttpPost]
        public async Task<IActionResult> PostCharlas([FromBody]CharlasRequest CharlasRequest)
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
            var entity = new Charlas
            {
                //TcharlaId = CharlasRequest.TcharlaId,
                Id = CharlasRequest.Id,
                Nombre = CharlasRequest.Nombre,
                PathLogo= CharlasRequest.Pathlogo,
                Usuario = user,
                Descripcion = CharlasRequest.Descripcion,
                FechaInicio = CharlasRequest.FechaInicio,
                FechaFin = CharlasRequest.FechaFin,
            };
            BaseController.CompletaRegistro(entity, 1, "", user, false);


            await this.context.Set<Charlas>().AddAsync(entity);
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
