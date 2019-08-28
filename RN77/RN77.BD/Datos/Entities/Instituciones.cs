using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Instituciones : EntityBase
    {
        public Instituciones()
        {
            Carreras = new HashSet<Carreras>();
            InstitucionDocumentos = new HashSet<InstitucionDocumentos>();
            InstitucionDomicilios = new HashSet<InstitucionDomicilios>();
            InstitucionMails = new HashSet<InstitucionMails>();
            InstitucionTels = new HashSet<InstitucionTels>();
        }


        public int TnotaId { get; set; }
        public string CodigoInstitucion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Tnotas Tnota { get; set; }
        public virtual ICollection<Carreras> Carreras { get; set; }
        public virtual ICollection<InstitucionDocumentos> InstitucionDocumentos { get; set; }
        public virtual ICollection<InstitucionDomicilios> InstitucionDomicilios { get; set; }
        public virtual ICollection<InstitucionMails> InstitucionMails { get; set; }
        public virtual ICollection<InstitucionTels> InstitucionTels { get; set; }
    }
}
