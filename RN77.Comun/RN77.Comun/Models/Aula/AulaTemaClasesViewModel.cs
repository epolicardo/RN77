using System;
using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Aula
{
    public class AulaTemaClasesViewModel
    {
        [Required]
        public int AulaId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public string NumUnidad { get; set; }
        [Required]
        public string Unidad { get; set; }
        [Required]
        public string TipoClase { get; set; }
        public string Contenido { get; set; }
        public string Actividades { get; set; }
    }
}
