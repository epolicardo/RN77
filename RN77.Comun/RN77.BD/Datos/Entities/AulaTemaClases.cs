using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaTemaClases : EntityBase
    {
        public AulaTemaClases()
        {
            AulaAsistencias = new HashSet<AulaAsistencias>();
        }


        public int AulaId { get; set; }
        public DateTime Fecha { get; set; }
        public string NumUnidad { get; set; }
        public string Unidad { get; set; }
        public string TipoClase { get; set; }
        public string Contenido { get; set; }
        public string Actividades { get; set; }

        public virtual Aulas Aula { get; set; }
        public virtual ICollection<AulaAsistencias> AulaAsistencias { get; set; }
    }
}
