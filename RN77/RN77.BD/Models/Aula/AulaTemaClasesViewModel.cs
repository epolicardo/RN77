using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RN77.BD.Models.Aula
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
