using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Persona.Request
{
    public class PersonaDomiciliosRequest
    {
        [Required]
        public int PersonaId { get; set; }

        [Required]
        public int DomicilioId { get; set; }
    }
}
