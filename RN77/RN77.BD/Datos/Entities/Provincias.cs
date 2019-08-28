using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Datos.Entities
{
   public partial class Provincias : EntityBase
   {
        public Provincias()
        {
            Ciudades = new HashSet<Ciudades>();
        }

        public int IdProvincia { get; set; }

        public string NombreProvincia { get; set; }

        public virtual ICollection<Ciudades> Ciudades { get; set; }
        
        public virtual Paises Paises { get; set; }
    }
}
