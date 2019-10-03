using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio.Request
{
    public class CiudadRequest
    {
        [Required]
        public int ProvinciaId { get; set; }

        [Required]
        public string NombreCiudad { get; set; }
    }
}
