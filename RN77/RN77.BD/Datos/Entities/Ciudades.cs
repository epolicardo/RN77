using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Datos.Entities
{
   public partial class Ciudades : EntityBase
    {
        public Ciudades()
        {
            Domicilios = new HashSet<Domicilios>();
        }
        public int ProvinciaId { get; set; }
        public string NombreCiudad { get; set; }

        public virtual Provincias Provincia { get; set; }

        public virtual ICollection<Domicilios> Domicilios { get; set; }
    }
}
