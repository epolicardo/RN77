using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaGrupoAlumnos : EntityBase
    {

        public int AulaGrupoId { get; set; }
        public int AulaAlumnoId { get; set; }

        public virtual AulaAlumnos AulaAlumno { get; set; }
        public virtual AulaGrupos AulaGrupo { get; set; }
    }
}
