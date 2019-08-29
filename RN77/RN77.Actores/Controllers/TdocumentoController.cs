using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos.Entities;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TdocumentoController : ControllerBase
    {
		private readonly RN77Context _context;

		public TdocumentoController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/Tdocumentos

		[HttpGet]

		public async Task<ActionResult<IEnumerable<Tdocumentos>>> GetTdocumentos()

		{

			return await _context.Tdocumentos.ToListAsync();

		}

		// GET: api/Tdocumentos

		[HttpGet("{id}")]

		public async Task<ActionResult<Tdocumentos>> GetTdocumentos(int id)

		{

			var tdocumentosItem = await _context.Tdocumentos.FindAsync(id);



			if (tdocumentosItem == null)

			{

				return NotFound();

			}



			return tdocumentosItem;

		}



		// POST: api/Documentos

		[HttpPost]

		public async Task<ActionResult<Tdocumentos>> PostTdocumento(Tdocumentos item)

		{

			_context.Tdocumentos.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetTdocumentos), new { id = item.Id }, item);

		}



		// PUT: api/Tdocumentos



		[HttpPut("{id}")]

		public async Task<IActionResult> PutTdocumentos(int id, Tdocumentos item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/Tdocumentos/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeleteTdocumentos(int id)

		{

			var tdocumentos = await _context.Tdocumentos.FindAsync(id);



			if (tdocumentos == null)

			{

				return NotFound();

			}



			_context.Tdocumentos.Remove(tdocumentos);

			await _context.SaveChangesAsync();



			return NoContent();

		}
	}
}