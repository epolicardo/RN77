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
    public class MailsController : ControllerBase
    {
        private readonly RN77Context context;

        public MailsController(RN77Context context)
        {
            this.context = context;


        }

        // GET: api/Carreras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mails>>> GetMails()
        {
            return await context.Mails.ToListAsync();
        }



        // GET: api/Carreras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mails>> GetMails(int id)
        {
            var mailsItem = await context.Mails.FindAsync(id);

            if (mailsItem == null)
            {
                return NotFound();
            }

            return mailsItem;
        }

        // POST: api/Carreras
        [HttpPost]
        public async Task<ActionResult<Mails>> PostMails(Mails item)
        {
            context.Mails.Add(item);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMails), new { id = item.Id }, item);
        }

        // PUT: api/Carreras/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarreras(int id, Mails item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Carreras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMails(int id)
        {
            var mails = await context.Mails.FindAsync(id);

            if (mails == null)
            {
                return NotFound();
            }

            context.Mails.Remove(mails);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}