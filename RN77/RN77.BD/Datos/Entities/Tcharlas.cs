namespace RN77.BD.Datos.Entities
{
    using System.Collections.Generic;

    public partial class Tcharlas : EntityBase
    {
        public Tcharlas()
        {
            Charlas = new HashSet<Charlas>();
        }


        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Charlas> Charlas { get; set; }
    }
}
