using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Ttels : EntityBase
    {
        public Ttels()
        {
            Tels = new HashSet<Tels>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Tels> Tels { get; set; }
    }
}
