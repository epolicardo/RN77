using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaAlumnos : EntityBase
    {
        public AulaAlumnos()
        {
            AulaAsistencias = new HashSet<AulaAsistencias>();
            AulaGrupoAlumnos = new HashSet<AulaGrupoAlumnos>();
            AulaNotas = new HashSet<AulaNotas>();
        }


        public int AulaId { get; set; }
        public int PersonaId { get; set; }

        public virtual Aulas Aula { get; set; }
        public virtual Personas Persona { get; set; }
        public virtual ICollection<AulaAsistencias> AulaAsistencias { get; set; }
        public virtual ICollection<AulaGrupoAlumnos> AulaGrupoAlumnos { get; set; }
        public virtual ICollection<AulaNotas> AulaNotas { get; set; }
    }
}
