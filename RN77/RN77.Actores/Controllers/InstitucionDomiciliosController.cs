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
    public class InstitucionDomiciliosController : ControllerBase
    {
		private readonly RN77Context _context;

		public InstitucionDomiciliosController(RN77Context context)
		{
			_context = context;
		}

		// GET: api/InstitucionDomicilios

		[HttpGet]

		public async Task<ActionResult<IEnumerable<InstitucionDomicilios>>> GetInstitucionDomicilios()

		{

			return await _context.InstitucionDomicilios.ToListAsync();

		}

		// GET: api/InstitucionDomicilios

		[HttpGet("{id}")]

		public async Task<ActionResult<InstitucionDomicilios>> GetInstitucionDomicilios(int id)

		{

			var institucionDomiciliosItem = await _context.InstitucionDomicilios.FindAsync(id);



			if (institucionDomiciliosItem == null)

			{

				return NotFound();

			}



			return institucionDomiciliosItem;

		}



		// POST: api/InstitucionDomicilios

		[HttpPost]

		public async Task<ActionResult<InstitucionDomicilios>> PostInstitucionDomicilios(InstitucionDomicilios item)

		{

			_context.InstitucionDomicilios.Add(item);

			await _context.SaveChangesAsync();



			return CreatedAtAction(nameof(GetInstitucionDomicilios), new { id = item.Id }, item);

		}



		// PUT: api/InstitucionDomicilios



		[HttpPut("{id}")]

		public async Task<IActionResult> PutInstitucionDomicilios(int id, InstitucionDomicilios item)

		{

			if (id != item.Id)

			{

				return BadRequest();

			}



			_context.Entry(item).State = EntityState.Modified;

			await _context.SaveChangesAsync();



			return NoContent();

		}



		// DELETE: api/InstitucionDomicilios/5

		[HttpDelete("{id}")]

		public async Task<IActionResult> DeleteInstitucionDomicilios(int id)

		{

			var institucionDomicilios = await _context.InstitucionDomicilios.FindAsync(id);



			if (institucionDomicilios == null)

			{

				return NotFound();

			}



			_context.InstitucionDomicilios.Remove(institucionDomicilios);

			await _context.SaveChangesAsync();



			return NoContent();

		}
	}
}