using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RN77.BD.Datos.Entities
{
    public partial class Paises : EntityBase  
    {
        public Paises()
        {
            Provincias = new HashSet<Provincias>();
        }

        [Required]
        [MaxLength(2)]
        public string CodigoPais { get; set; }

        [Required]
        public string NombrePais { get; set; }
       
        public virtual ICollection<Provincias> Provincias { get; set; }
    }
}
