using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Models.Charla
{
    public class CharlasViewModel
    {
        public int TcharlaId { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {get; set;}
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin{ get; set; }
        public string Pathlogo { get; set; }
    }
}
