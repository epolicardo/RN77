using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Aulas : EntityBase
    {
        public Aulas()
        {
            AulaAlumnos = new HashSet<AulaAlumnos>();
            AulaDocentes = new HashSet<AulaDocentes>();
            AulaEvaluaciones = new HashSet<AulaEvaluaciones>();
            AulaGrupos = new HashSet<AulaGrupos>();
            AulaTemaClases = new HashSet<AulaTemaClases>();
        }


        public int? NotasValidaId { get; set; }
        public int? AsistenciaValidaId { get; set; }
        public int? CharlaId { get; set; }
        public int? CarreraId { get; set; }
        public int? CarreraMateriaId { get; set; }
        public string CodigoAula { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int AnoLectivo { get; set; }
        public string Periodo { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }

        public virtual Carreras Carrera { get; set; }
        public virtual CarreraMaterias CarreraMateria { get; set; }
        public virtual Charlas Charla { get; set; }
        public virtual ICollection<AulaAlumnos> AulaAlumnos { get; set; }
        public virtual ICollection<AulaDocentes> AulaDocentes { get; set; }
        public virtual ICollection<AulaEvaluaciones> AulaEvaluaciones { get; set; }
        public virtual ICollection<AulaGrupos> AulaGrupos { get; set; }
        public virtual ICollection<AulaTemaClases> AulaTemaClases { get; set; }
    }
}
