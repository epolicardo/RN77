using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Persona.Request
{
    public class PersonaDocumentosRequest
    {
        [Required]
        public int PersonaId { get; set; }

        [Required]
        public int DocumentoId { get; set; }
    }
}
