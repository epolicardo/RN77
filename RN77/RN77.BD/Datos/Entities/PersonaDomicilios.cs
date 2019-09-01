using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class PersonaDomicilios : EntityBase
    {
        public int PersonaId { get; set; }
        public int DomicilioId { get; set; }

        public virtual Personas Persona { get; set; }
        public virtual Domicilios Domicilio { get; set; }
    }
}
