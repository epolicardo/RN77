using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Persona.Request
{
    public class PersonaMailsRequest
    {
        [Required]
        public int PersonaId { get; set; }

        [Required]
        public int MailId { get; set; }
    }
}

