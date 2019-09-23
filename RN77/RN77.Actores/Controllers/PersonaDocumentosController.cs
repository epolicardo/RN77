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
    public class PersonaDocumentosController : ControllerBase
    {
		private readonly RN77Context _context;

		public PersonaDocumentosController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/PersonaDocumentos

		[HttpGet]

		public async Task<ActionResult<IEnumerable<PersonaDocumentos>>> GetPersonaDocumentos()

		{

			return await _context.PersonaDocumentos.ToListAsync();

		}

		// GET: api/PersonaDocumentos

		[HttpGet("{id}")]

		public async Task<ActionResult<PersonaDocumentos>> GetPersonaDocumentos(int id)

		{

			var personaDocumentosItem = await _context.PersonaDocumentos.FindAsync(id);



			if (personaDocumentosItem == null)

			{

				return NotFound();

			}



			return personaDocumentosItem;

		}



		// POST: api/Personas

		[HttpPost]

		public async Task<ActionResult<PersonaTels>> PostPersonaDocumentos(PersonaDocumentos item)

		{

			_context.PersonaDocumentos.Add(item);

			await _context.SaveChangesAsync();   



			return CreatedAtAction(nameof(GetPersonaDocumentos), new { id = item.Id }, item);

		}



		// PUT: api/PersonaDocumentos



		[HttpPut("{id}")]

		public async Task<IActionResult> PutPersonaDocumentos(int id, PersonaDocumentos item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/PersonaDocumentos/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeletePersonaDocumentos(int id)

		{

			var personaDocumentos = await _context.PersonaDocumentos.FindAsync(id);



			if (personaDocumentos == null)

			{

				return NotFound();

			}



			_context.PersonaDocumentos.Remove(personaDocumentos);

			await _context.SaveChangesAsync();



			return NoContent();

		}
	}
}