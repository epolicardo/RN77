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
    public class PersonaTelsController : ControllerBase
    {
		private readonly RN77Context _context;

		public PersonaTelsController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/PersonaTels

		[HttpGet]

		public async Task<ActionResult<IEnumerable<PersonaTels>>> GetPersonaTels()

		{

			return await _context.PersonaTels.ToListAsync();

		}

		// GET: api/PersonaTels

		[HttpGet("{id}")]

		public async Task<ActionResult<PersonaTels>> GetPersonaTels(long id)

		{

			var personaTelsItem = await _context.PersonaTels.FindAsync(id);



			if (personaTelsItem == null)

			{

				return NotFound();

			}



			return personaTelsItem;

		}



		// POST: api/Personas

		[HttpPost]

		public async Task<ActionResult<PersonaTels>> PostPersonaTels(PersonaTels item)

		{

			_context.PersonaTels.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetPersonaTels), new { id = item.Id }, item);

		}



		// PUT: api/PersonaTels



		[HttpPut("{id}")]

		public async Task<IActionResult> PutPersonaTels(long id, PersonaTels item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/PersonaTels/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeletePersonaTels(long id)

		{

			var personaTels = await _context.PersonaTels.FindAsync(id);



			if (personaTels == null)

			{

				return NotFound();

			}



			_context.PersonaTels.Remove(personaTels);

			await _context.SaveChangesAsync();



			return NoContent();

		}
	}
}