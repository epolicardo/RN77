using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaAsistencias : EntityBase
    {

        public int? AulaTemaClaseId { get; set; }
        public int AulaAlumnoId { get; set; }
        public DateTime Fecha { get; set; }
        public string NumUnidad { get; set; }
        public string Unidad { get; set; }
        public string TipoClase { get; set; }
        public string Contenido { get; set; }
        public string Actividades { get; set; }

        public virtual AulaAlumnos AulaAlumno { get; set; }
        public virtual AulaTemaClases AulaTemaClase { get; set; }
    }
}
