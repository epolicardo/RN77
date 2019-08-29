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
    public class DocumentosController : ControllerBase
    {
		private readonly RN77Context _context;

		public DocumentosController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/PersonaTels

		[HttpGet]

		public async Task<ActionResult<IEnumerable<Documentos>>> GetDocumentos()

		{

			return await _context.Documentos.ToListAsync();

		}

		// GET: api/Documentos

		[HttpGet("{id}")]

		public async Task<ActionResult<Documentos>> GetDocumentos(int id)

		{

			var documentosItem = await _context.Documentos.FindAsync(id);



			if (documentosItem == null)

			{

				return NotFound();

			}



			return documentosItem;

		}



		// POST: api/Documentos

		[HttpPost]

		public async Task<ActionResult<Documentos>> PostPersonaTels(Documentos item)

		{

			_context.Documentos.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetDocumentos), new { id = item.Id }, item);

		}



		// PUT: api/Documentos



		[HttpPut("{id}")]

		public async Task<IActionResult> PutDocumentos(long id, Documentos item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/Documentos/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeleteDocumentos(int id)

		{

			var documentos = await _context.Documentos.FindAsync(id);



			if (documentos == null)

			{

				return NotFound();

			}



			_context.Documentos.Remove(documentos);

			await _context.SaveChangesAsync();



			return NoContent();

		}
	}
}