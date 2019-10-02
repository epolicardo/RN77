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
    public class PersonaMailsController : ControllerBase
    {

		private readonly RN77Context _context;

		public PersonaMailsController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/PersonaMails

		[HttpGet]

		public async Task<ActionResult<IEnumerable<PersonaMails>>> GetPersonaMails()

		{

			return await _context.PersonaMails.ToListAsync();

		}

		// GET: api/PersonaMails

		[HttpGet("{id}")]

		public async Task<ActionResult<PersonaMails>> GetPersonaMails(long id)

		{

			var personaMailsItem = await _context.PersonaMails.FindAsync(id);



			if (personaMailsItem == null)

			{

				return NotFound();

			}



			return personaMailsItem;

		}



		// POST: api/Personas

		[HttpPost]

		public async Task<ActionResult<PersonaDomicilios>> PostPersonaMails(PersonaMails item)

		{

			_context.PersonaMails.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetPersonaMails), new { id = item.Id }, item);

		}



		// PUT: api/PersonaDomicilios



		[HttpPut("{id}")]

		public async Task<IActionResult> PutPersonaMails(long id, PersonaMails item)

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

		public async Task<IActionResult> DeletePersonaMails(long id)

		{

			var personaMails = await _context.PersonaMails.FindAsync(id);



			if (personaMails == null)

			{

				return NotFound();

			}



			_context.PersonaMails.Remove(personaMails);

			await _context.SaveChangesAsync();



			return NoContent();

		}
	}
}