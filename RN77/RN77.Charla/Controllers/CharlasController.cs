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
using RN77.BD.Models.Charla;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public async Task<IActionResult> PostCharlas([FromBody]CharlasViewModel CharlasViewModel)
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
                TcharlaId = CharlasViewModel.TcharlaId,
                Id = CharlasViewModel.Id,
                Nombre = CharlasViewModel.Nombre,
                PathLogo= CharlasViewModel.Pathlogo,
                Usuario = user,
                Descripcion = CharlasViewModel.Descripcion,
                FechaInicio = CharlasViewModel.FechaInicio,
                FechaFin = CharlasViewModel.FechaFin,
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
