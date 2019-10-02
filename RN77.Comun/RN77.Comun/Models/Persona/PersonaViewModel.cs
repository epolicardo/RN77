using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Persona
{
    public class PersonaViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
    }
}
