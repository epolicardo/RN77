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
using RN77.BD.Models.Domicilio;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly RN77Context context;
        //private readonly IUsuarioHelper usuarioHelper;

        public PaisesController(RN77Context context)
        {
            this.context = context;
            //this.usuarioHelper = usuarioHelper;
        }

        // GET: api/Paises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPaises()
        {
            return await context.Paises.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paises>> GetPaises(int id)
        {
            var paisesItem = await context.Paises.FindAsync(id);

            if (paisesItem == null)
            {
                return NotFound();
            }

            return paisesItem;
        }

        // POST:/api/Paises
        // en body
        // {
        //     "nombrePais": "Peru",
        // }
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] PaisViewModel paisViewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var user = await context.Users.FindAsync("1");
            if (user == null)
            {
                return this.BadRequest("Usuario Invalido");
            }

            var entity = new Paises
            {
                NombrePais = paisViewModel.NombrePais,
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
        //     "nombrePais": "Peru",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaises(int id, [FromBody] PaisViewModel paisViewModel)
        {

            var entity = await this.context.Set<Paises>().FindAsync(id);
            entity.NombrePais = paisViewModel.NombrePais;
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaises(int id)
        {
            var paises = await context.Paises.FindAsync(id);

            if (paises == null)
            {
                return NotFound();
            }

            context.Paises.Remove(paises);
            await context.SaveChangesAsync();

            return Ok();
        }
 
    }

}