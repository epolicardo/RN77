using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class CarreraMaterias : EntityBase
    {
        public CarreraMaterias()
        {
            Aulas = new HashSet<Aulas>();
        }


        public int CarreraId { get; set; }
        public int CarreraMateriaId { get; set; }
        public string CodigoMateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Carreras Carrera { get; set; }
        public virtual Materias CarreraMateria { get; set; }
        public virtual ICollection<Aulas> Aulas { get; set; }
    }
}
