using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio.Request
{
    public class ProvinciaRequest
    {
        [Required]
        public int PaisId { get; set; }

        [Required]
        public string NombreProvincia { get; set; }
    }
}
