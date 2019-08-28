using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class CharlaDigos : EntityBase
    {
        public CharlaDigos()
        {
            CharlaDigoArchivos = new HashSet<CharlaDigoArchivos>();
            CharlaDigoLinks = new HashSet<CharlaDigoLinks>();
            CharlaLeeDigos = new HashSet<CharlaLeeDigos>();
            InverseCharlaDigoDeDigo = new HashSet<CharlaDigos>();
        }


        public int CharlaId { get; set; }
        public int CharlaPersonaId { get; set; }
        public int? CharlaDigoDeDigoId { get; set; }
        public string Digo { get; set; }
        public DateTime FechaDigo { get; set; }

        public virtual Charlas Charla { get; set; }
        public virtual CharlaDigos CharlaDigoDeDigo { get; set; }
        public virtual CharlaPersonas CharlaPersona { get; set; }
        public virtual ICollection<CharlaDigoArchivos> CharlaDigoArchivos { get; set; }
        public virtual ICollection<CharlaDigoLinks> CharlaDigoLinks { get; set; }
        public virtual ICollection<CharlaLeeDigos> CharlaLeeDigos { get; set; }
        public virtual ICollection<CharlaDigos> InverseCharlaDigoDeDigo { get; set; }
    }
}
