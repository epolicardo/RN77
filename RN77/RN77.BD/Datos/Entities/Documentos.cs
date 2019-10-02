using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Documentos : EntityBase
    {
        public Documentos()
        {
            InstitucionDocumentos = new HashSet<InstitucionDocumentos>();
            PersonaDocumentos = new HashSet<PersonaDocumentos>();
        }


        public int TdocumentoId { get; set; }
        public string Documento { get; set; }

        public virtual Tdocumentos Tdocumento { get; set; }
        public virtual ICollection<InstitucionDocumentos> InstitucionDocumentos { get; set; }
        public virtual ICollection<PersonaDocumentos> PersonaDocumentos { get; set; }
    }
}
