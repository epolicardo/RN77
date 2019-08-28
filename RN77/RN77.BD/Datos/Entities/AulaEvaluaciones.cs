using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaEvaluaciones : EntityBase
    {
        public AulaEvaluaciones()
        {
            AulaNotas = new HashSet<AulaNotas>();
        }


        public int AulaId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoEvaluacion { get; set; }
        public byte SePromedia { get; set; }
        public string Descripcion { get; set; }

        public virtual Aulas Aula { get; set; }
        public virtual ICollection<AulaNotas> AulaNotas { get; set; }
    }
}
