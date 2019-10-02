using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class InstitucionMails : EntityBase
    {

        public int InstitucionId { get; set; }
        public int MailId { get; set; }

        public virtual Instituciones Institucion { get; set; }
        public virtual Mails Mail { get; set; }
    }
}
