using System;
using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class CharlaDigoLinks : EntityBase
    {

        public int? CharlaDigoId { get; set; }
        public string Link { get; set; }
        public string Comentario { get; set; }

        public virtual CharlaDigos CharlaDigo { get; set; }
    }
}
