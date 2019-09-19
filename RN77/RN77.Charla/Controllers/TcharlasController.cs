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
                return this.BadRequest("No existe tal Charla");
            }
            return TcharlaItem;
        }

        // POST api/Tcharlas
        [HttpPost]
        public async Task<IActionResult> PostTcharlas([FromBody]TcharlasViewModel TcharlasViewModel)
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
            var entity = new Tcharlas
            {
                Codigo = TcharlasViewModel.Codigo,
                Nombre = TcharlasViewModel.Nombre,
                Descripcion = TcharlasViewModel.Descripcion,
            };
            BaseController.CompletaRegistro(entity, 1, "", user, false);


            await this.context.Set<Tcharlas>().AddAsync(entity);
            try
            {
                await this.context.SaveChangesAsync();
            }
            catch (Exception)
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
