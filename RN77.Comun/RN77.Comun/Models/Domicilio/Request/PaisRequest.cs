using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio.Request
{
    public class PaisRequest
    {
        [Required]
        public string CodigoPais { get; set; }

        [Required]
        public string NombrePais { get; set; }
    }
}
