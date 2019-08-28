using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Domicilios : EntityBase
    {
        public Domicilios()
        {
            InstitucionDomicilios = new HashSet<InstitucionDomicilios>();
            PersonaDomicilios = new HashSet<PersonaDomicilios>();
        }


        public int TdomicilioId { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public string Barrio { get; set; }
        public string Cp { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual Tdomicilios Tdomicilio { get; set; }
        public virtual ICollection<InstitucionDomicilios> InstitucionDomicilios { get; set; }
        public virtual ICollection<PersonaDomicilios> PersonaDomicilios { get; set; }
    }
}
