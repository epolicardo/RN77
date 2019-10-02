using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Carreras : EntityBase
    {
        public Carreras()
        {
            Aulas = new HashSet<Aulas>();
            CarreraMaterias = new HashSet<CarreraMaterias>();
        }


        public int InstitucionId { get; set; }
        public string CodigoCarrera { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Instituciones Institucion { get; set; }
        public virtual ICollection<Aulas> Aulas { get; set; }
        public virtual ICollection<CarreraMaterias> CarreraMaterias { get; set; }
    }
}
