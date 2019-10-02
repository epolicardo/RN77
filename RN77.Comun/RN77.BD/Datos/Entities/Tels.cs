using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Tels : EntityBase
    {
        public Tels()
        {
            InstitucionTels = new HashSet<InstitucionTels>();
            PersonaTels = new HashSet<PersonaTels>();
        }


        public int TtelId { get; set; }
        public string Tel { get; set; }

        public virtual Ttels Ttel { get; set; }
        public virtual ICollection<InstitucionTels> InstitucionTels { get; set; }
        public virtual ICollection<PersonaTels> PersonaTels { get; set; }
    }
}
