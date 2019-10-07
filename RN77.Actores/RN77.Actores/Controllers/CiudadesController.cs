using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Domicilio.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadesController : ControllerBase
    {
        private readonly RN77Context context;

        public CiudadesController(RN77Context context)
        {
            this.context = context;
        }

        // GET: api/Ciudades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudades>>> GetCiudades()
        {
            return await this.context.Ciudades.Include(p => p.Usuario).ToListAsync();
        }

        // GET: api/Ciudades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudades>> GetCiudades(int id)
        {
            var ciudadesItem = await this.context.Ciudades.FindAsync(id);

            if (ciudadesItem == null)
            {
                return this.BadRequest("No existen Ciudades.");
            }

            return ciudadesItem;
        }

        // POST:/api/Ciudades
        // en body
        // {
        //     "paisId": 1,
        //     "nombreCiudad": "Rio Tercero",
        // }
      
        [HttpPost]
        public async Task<IActionResult> PostCiudades([FromBody] CiudadRequest ciudadRequest)
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

            var provincia = await this.context.Provincias.FindAsync(ciudadRequest.ProvinciaId);
            if (provincia == null)
            {
                return this.BadRequest("Provincia no existe.");
            }

            var entity = new Ciudades
            {
                NombreCiudad = ciudadRequest.NombreCiudad,
                Provincia = provincia,
                Usuario = user,
            };

            BaseController.CompletaRegistro(entity, 1, "", user, false);

            await this.context.Set<Ciudades>().AddAsync(entity);
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

        // PUT: api/Ciudades/5
        // en body
        // {
        //     "provinciaId": 1,
        //     "nombreCiudad": "Rio Tercero",
        // }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudades(int id, [FromBody] CiudadRequest ciudadRequest)
        {

            var entity = await this.context.Set<Ciudades>().FindAsync(id);

            var provincia = await this.context.Provincias.FindAsync(ciudadRequest.ProvinciaId);
            if (provincia == null)
            {
                return this.BadRequest("Provincia no existe.");
            }
            entity.Provincia = provincia;
            entity.NombreCiudad = ciudadRequest.NombreCiudad;
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();

            return Ok(entity);
        }

        // DELETE: api/Ciudades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudades(int id)
        {
            var ciudades = await this.context.Ciudades.FindAsync(id);

            if (ciudades == null)
            {
                return this.BadRequest("Ciudad no existe.");
            }

            this.context.Ciudades.Remove(ciudades);
            await this.context.SaveChangesAsync();

            return Ok();
        }

    }
}
