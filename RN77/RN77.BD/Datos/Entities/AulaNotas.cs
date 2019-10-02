using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaNotas : EntityBase
    {

        public int? AulaEvaluacionId { get; set; }
        public int AulaAlumnoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Valor { get; set; }

        public virtual AulaAlumnos AulaAlumno { get; set; }
        public virtual AulaEvaluaciones AulaEvaluacion { get; set; }
    }
}
