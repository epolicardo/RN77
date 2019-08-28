using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Tmails : EntityBase
    {
        public Tmails()
        {
            Mails = new HashSet<Mails>();
        }


        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Mails> Mails { get; set; }
    }
}
