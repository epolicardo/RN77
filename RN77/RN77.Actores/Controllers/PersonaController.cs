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
using RN77.BD.Models.Persona;

namespace RN77.Actores.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonasController : ControllerBase
	{
		private readonly RN77Context context;

		public PersonasController(RN77Context context)
		{
			this.context = context;
		}

		// GET: api/Personas

		[HttpGet]

		public async Task<ActionResult<IEnumerable<Personas>>> GetPersonas()

		{

			return await this.context.Personas.Include(p => p.Usuario).ToListAsync();

		}


		// GET: api/Personas

		[HttpGet("{id}")]

		public async Task<ActionResult<Personas>> GetPersonas(long id)

		{

			var personasItem = await this.context.Personas.FindAsync(id);



			if (personasItem == null)

			{

				return this.BadRequest("No existen Personas.");

			}



			return personasItem;

		}



		// POST: api/Personas

		[HttpPost]

		public async Task<IActionResult> PostPersona([FromBody] PersonaViewModel personaViewModel)

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

			var entity = new Personas
			{
				Nombre = personaViewModel.Nombre,
				Apellido = personaViewModel.Apellido,
				Usuario = user,
			};

			BaseController.CompletaRegistro(entity, 1, "", user, false);

			await this.context.Set<Personas>().AddAsync(entity);
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



		// PUT: api/Personas/5



		[HttpPut("{id}")]

		public async Task<IActionResult> PutPersonas(int id, [FromBody] PersonaViewModel personaViewModel)

		{

			var entity = await this.context.Set<Personas>().FindAsync(id);
			entity.Nombre = personaViewModel.Nombre;
			this.context.Entry(entity).State = EntityState.Modified;
			await this.context.SaveChangesAsync();

			return Ok(entity);
		}



		// DELETE: api/personas/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeletePersonas(int id)

		{
			var personas = await this.context.Personas.FindAsync(id);

			if (personas == null)
			{
				return this.BadRequest("Personas no existe.");
			}

			this.context.Personas.Remove(personas);
			await this.context.SaveChangesAsync();

			return Ok();
		}

	}
}