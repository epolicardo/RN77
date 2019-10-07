using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Persona.Request
{
    public class PersonaRequest
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
    }
}
