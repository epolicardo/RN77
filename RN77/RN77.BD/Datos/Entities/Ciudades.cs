using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RN77.BD.Datos.Entities
{
   public partial class Ciudades : EntityBase
    {
        public Ciudades()
        {
            Domicilios = new HashSet<Domicilios>();
        }

        [Required]
        public int ProvinciaId { get; set; }

        [Required]
        public string NombreCiudad { get; set; }

        public virtual Provincias Provincia { get; set; }

        public virtual ICollection<Domicilios> Domicilios { get; set; }
    }
}
