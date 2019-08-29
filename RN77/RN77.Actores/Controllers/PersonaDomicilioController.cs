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
    public class PersonaDomicilioController : ControllerBase
    {
		private readonly RN77Context _context;

		public PersonaDomicilioController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/PersonaDomicilios

		[HttpGet]

		public async Task<ActionResult<IEnumerable<PersonaDomicilios>>> GetPersonaDomicilios()

		{

			return await _context.PersonaDomicilios.ToListAsync();

		}

		// GET: api/PersonaDomicilios

		[HttpGet("{id}")]

		public async Task<ActionResult<PersonaDomicilios>> GetPersonaDomicilios(long id)

		{

			var personaDomiciliosItem = await _context.PersonaDomicilios.FindAsync(id);



			if (personaDomiciliosItem == null)

			{

				return NotFound();

			}



			return personaDomiciliosItem;

		}



		// POST: api/Personas

		[HttpPost]

		public async Task<ActionResult<PersonaDomicilios>> PostPersonaDomicilios(PersonaDomicilios item)

		{

			_context.PersonaDomicilios.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetPersonaDomicilios), new { id = item.Id }, item);

		}



		// PUT: api/PersonaDomicilios



		[HttpPut("{id}")]

		public async Task<IActionResult> PutPersonaDomicilios(long id, PersonaDomicilios item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/Domicilios/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeletePersonaDomicilios(long id)

		{

			var personaDomicilios = await _context.PersonaDomicilios.FindAsync(id);



			if (personaDomicilios == null)

			{

				return NotFound();

			}



			_context.PersonaDomicilios.Remove(personaDomicilios);

			await _context.SaveChangesAsync();



			return NoContent();

		}


	}
}