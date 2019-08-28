using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class InstitucionDomicilios : EntityBase
    {

        public int InstitucionId { get; set; }
        public int DomicilioId { get; set; }

        public virtual Domicilios Domicilio { get; set; }
        public virtual Instituciones Institucion { get; set; }
    }
}
