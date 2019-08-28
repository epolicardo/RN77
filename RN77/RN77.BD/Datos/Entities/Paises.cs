using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Datos.Entities
{
    public partial class Paises : EntityBase  
    {
        public Paises()
        {
            Provincias = new HashSet<Provincias>();
            Ciudades = new HashSet<Ciudades>();
        }

        public int IdPais{ get; set; }

        public string NombrePais { get; set; }
       
        public virtual ICollection<Provincias> Provincias { get; set; }
        public virtual ICollection<Ciudades> Ciudades { get; set; }
    }
}
