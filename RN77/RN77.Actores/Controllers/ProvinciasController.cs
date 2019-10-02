using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Models.Domicilio;
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
            var provinciasItem = await this.context.Provincias.FindAsync(id);

            if (provinciasItem == null)
            {
                return this.BadRequest("No existen Provincias.");
            }

            return provinciasItem;
        }

        // POST:/api/Provincias
        // en body
        // {
        //     "paisId": 1,
        //     "nombreProvincia": "Córdoba",
        // }
        [HttpPost]
        public async Task<IActionResult> PostProvincias([FromBody] ProvinciaViewModel provinciaViewModel)
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

            var pais = await this.context.Paises.FindAsync(provinciaViewModel.PaisId);
            if (pais == null)
            {
                return this.BadRequest("Pais no existe.");
            }

            var entity = new Provincias
            {
                NombreProvincia = provinciaViewModel.NombreProvincia,
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
                return this.BadRequest("Registro no grabado, controlar.");
            }

            return Ok(entity);
        }

        // PUT: api/Provincias/5
        // en body
        // {
        //     "paisId": 1,
        //     "nombreProvincia": "Córdoba",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvincias(int id, [FromBody] ProvinciaViewModel provinciaViewModel)
        {

            var entity = await this.context.Set<Provincias>().FindAsync(id);

            var pais = await this.context.Paises.FindAsync(provinciaViewModel.PaisId);
            if (pais == null)
            {
                return this.BadRequest("Pais no existe.");
            }
            entity.Pais = pais;
            entity.NombreProvincia = provinciaViewModel.NombreProvincia;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Provincias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvincias(int id)
        {
            var provincias = await this.context.Provincias.FindAsync(id);

            if (provincias == null)
            {
                return this.BadRequest("Provincia no existe.");
            }

            this.context.Provincias.Remove(provincias);
            await this.context.SaveChangesAsync();

            return Ok();
        }

    }

}