using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio
{
    public class ProvinciaViewModel
    {
        [Required]
        public int PaisId { get; set; }

        [Required]
        public string NombreProvincia { get; set; }
    }
}
