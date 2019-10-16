using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Persona.Request;
using RN77.Comun.Models.Varios;

namespace RN77.Actores.Controllers
{
    public interface IPersonaController
    {
        Task<IActionResult> DeletePersona(int id);
        Task<ActionResult<IEnumerable<Personas>>> GetPersona();
        Task<ActionResult<Personas>> GetPersona(long id);
        Task<ActionResult<Respuesta>> PostPersona([FromBody] PersonaRequest peticion);
        Task<IActionResult> PutPersona(int id, [FromBody] PersonaRequest peticion);
    }
}