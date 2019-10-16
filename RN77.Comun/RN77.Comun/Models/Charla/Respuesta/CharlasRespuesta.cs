using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Charla.Respuesta
{
    public class CharlasRespuesta
    {

        public int TcharlaId { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Pathlogo { get; set; }
    }
}
