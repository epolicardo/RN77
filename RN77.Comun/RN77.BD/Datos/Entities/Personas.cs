using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Personas : EntityBase
    {
        public Personas()
        {
            AulaAlumnos = new HashSet<AulaAlumnos>();
            AulaDocentes = new HashSet<AulaDocentes>();
            CharlaPersonas = new HashSet<CharlaPersonas>();
            PersonaDocumentos = new HashSet<PersonaDocumentos>();
            PersonaDomicilios = new HashSet<PersonaDomicilios>();
            PersonaMails = new HashSet<PersonaMails>();
            PersonaTels = new HashSet<PersonaTels>();
        }


        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<AulaAlumnos> AulaAlumnos { get; set; }
        public virtual ICollection<AulaDocentes> AulaDocentes { get; set; }
        public virtual ICollection<CharlaPersonas> CharlaPersonas { get; set; }
        public virtual ICollection<PersonaDocumentos> PersonaDocumentos { get; set; }
        public virtual ICollection<PersonaDomicilios> PersonaDomicilios { get; set; }
        public virtual ICollection<PersonaMails> PersonaMails { get; set; }
        public virtual ICollection<PersonaTels> PersonaTels { get; set; }
    }
}
