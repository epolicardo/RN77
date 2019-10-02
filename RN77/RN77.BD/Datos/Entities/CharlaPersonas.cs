using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class CharlaPersonas : EntityBase
    {
        public CharlaPersonas()
        {
            CharlaDigos = new HashSet<CharlaDigos>();
            CharlaLeeDigos = new HashSet<CharlaLeeDigos>();
        }


        public int CharlaId { get; set; }
        public int PersonaId { get; set; }

        public virtual Charlas Charla { get; set; }
        public virtual Personas Persona { get; set; }
        public virtual ICollection<CharlaDigos> CharlaDigos { get; set; }
        public virtual ICollection<CharlaLeeDigos> CharlaLeeDigos { get; set; }
    }
}
