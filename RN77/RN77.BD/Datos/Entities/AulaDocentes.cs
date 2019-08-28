using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class AulaDocentes : EntityBase
    {

        public int AulaId { get; set; }
        public int PersonaId { get; set; }

        public virtual Aulas Aula { get; set; }
        public virtual Personas Persona { get; set; }
    }
}
