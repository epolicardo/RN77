using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Aula
{
    public class AulaViewModel
    {
        [Required]
        public string CodigoAula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int AnoLectivo { get; set; }
        [Required]
        [MaxLength(2)]
        public string Periodo { get; set; }

    }
}
