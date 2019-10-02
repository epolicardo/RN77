using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio
{
    public class CiudadViewModel
    {
        [Required]
        public int ProvinciaId { get; set; }

        [Required]
        public string NombreCiudad { get; set; }
    }
}
