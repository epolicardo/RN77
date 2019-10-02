using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio
{
    public class PaisViewModel
    {
        [Required]
        public string CodigoPais { get; set; }

        [Required]
        public string NombrePais { get; set; }
    }
}
