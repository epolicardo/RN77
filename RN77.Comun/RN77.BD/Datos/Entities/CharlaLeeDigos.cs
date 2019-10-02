using System;

namespace RN77.BD.Datos.Entities
{
    public partial class CharlaLeeDigos : EntityBase
    {

        public int? CharlaDigoId { get; set; }
        public int CharlaPersonaId { get; set; }
        public DateTime FechaNotifico { get; set; }
        public DateTime? FechaRecibe { get; set; }
        public DateTime? FechaLeo { get; set; }

        public virtual CharlaDigos CharlaDigo { get; set; }
        public virtual CharlaPersonas CharlaPersona { get; set; }
    }
}
