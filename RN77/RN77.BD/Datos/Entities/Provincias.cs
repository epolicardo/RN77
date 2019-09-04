using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Datos.Entities
{
   public partial class Provincias : EntityBase
   {
        public virtual Paises Pais { get; set; }
        public virtual ICollection<Ciudades> Ciudades { get; set; }

        public Provincias()
        {
            Ciudades = new HashSet<Ciudades>();
        }

        public int PaisId { get; set; }
        public string NombreProvincia { get; set; }
    }
}
