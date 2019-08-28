using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Datos.Entities
{
   public partial class Ciudades : EntityBase
    {

        public int IdCiudad { get; set; }

        public string NombreCiudad { get; set; }

        public virtual Provincias Provincias { get; set; }

     }
}
