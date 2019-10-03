using System;

namespace RN77.Comun.Models.Charla.Request
{
    public class CharlasRequest
    {
        public int TcharlaId { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Pathlogo { get; set; }
    }
}
