using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Materias : EntityBase
    {
        public Materias()
        {
            CarreraMaterias = new HashSet<CarreraMaterias>();
        }


        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CarreraMaterias> CarreraMaterias { get; set; }
    }
}
