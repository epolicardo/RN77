using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Charlas : EntityBase
    {
        public Charlas()
        {
            AulaGrupos = new HashSet<AulaGrupos>();
            Aulas = new HashSet<Aulas>();
            CharlaDigos = new HashSet<CharlaDigos>();
            CharlaPersonas = new HashSet<CharlaPersonas>();
        }


        public int TcharlaId { get; set; }
        public string CodigoCharla { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string PathLogo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public virtual Tcharlas Tcharla { get; set; }
        public virtual ICollection<AulaGrupos> AulaGrupos { get; set; }
        public virtual ICollection<Aulas> Aulas { get; set; }
        public virtual ICollection<CharlaDigos> CharlaDigos { get; set; }
        public virtual ICollection<CharlaPersonas> CharlaPersonas { get; set; }
    }
}
