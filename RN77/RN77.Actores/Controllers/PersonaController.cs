using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;

namespace RN77.Actores.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonasController : ControllerBase
	{
		private readonly RN77Context _context;

		public PersonasController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/Personas

		[HttpGet]

		public async Task<ActionResult<IEnumerable<Personas>>> GetPersonas()

		{

			return await _context.Personas.ToListAsync();

		}


		// GET: api/Personas

		[HttpGet("{id}")]

		public async Task<ActionResult<Personas>> GetPersonas(long id)

		{

			var personasItem = await _context.Personas.FindAsync(id);



			if (personasItem == null)

			{

				return NotFound();

			}



			return personasItem;

		}



		// POST: api/Personas

		[HttpPost]

		public async Task<ActionResult<Personas>> PostPersonas(Personas item)

		{

			_context.Personas.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetPersonas), new { id = item.Id }, item);

		}



		// PUT: api/Personas/5



		[HttpPut("{id}")]

		public async Task<IActionResult> PutPersonas(long id, Personas item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/personas/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeletePersonas(long id)

		{

			var personas = await _context.Personas.FindAsync(id);



			if (personas == null)

			{

				return NotFound();

			}

			_context.Personas.Remove(personas);

			await _context.SaveChangesAsync();



			return NoContent();

		}

	}
}