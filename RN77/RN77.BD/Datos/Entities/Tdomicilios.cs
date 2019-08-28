using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Tdomicilios : EntityBase
    {
        public Tdomicilios()
        {
            Domicilios = new HashSet<Domicilios>();
        }


        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Domicilios> Domicilios { get; set; }
    }
}
