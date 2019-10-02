using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaGrupos : EntityBase
    {
        public AulaGrupos()
        {
            AulaGrupoAlumnos = new HashSet<AulaGrupoAlumnos>();
        }


        public int AulaId { get; set; }
        public int CharlaId { get; set; }
        public string CodigoGrupo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Aulas Aula { get; set; }
        public virtual Charlas Charla { get; set; }
        public virtual ICollection<AulaGrupoAlumnos> AulaGrupoAlumnos { get; set; }
    }
}
