using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RN77.BD.Datos.Entities
{
    public partial class Tdocumentos : EntityBase
    {
        public Tdocumentos()
        {
            Documentos = new HashSet<Documentos>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Documentos> Documentos { get; set; }
    }
}
