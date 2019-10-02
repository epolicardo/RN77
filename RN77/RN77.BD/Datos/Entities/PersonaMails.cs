using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class PersonaMails : EntityBase
    {

        public int PersonaId { get; set; }
        public int MailId { get; set; }

        public virtual Mails Mail { get; set; }
        public virtual Personas Persona { get; set; }
    }
}
