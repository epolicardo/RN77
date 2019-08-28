using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Tnotas : EntityBase
    {
        public Tnotas()
        {
            Instituciones = new HashSet<Instituciones>();
        }


        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ValorMin { get; set; }
        public string ValorMax { get; set; }
        public int Paso { get; set; }

        public virtual ICollection<Instituciones> Instituciones { get; set; }
    }
}
