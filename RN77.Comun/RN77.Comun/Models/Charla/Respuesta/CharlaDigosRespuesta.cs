using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Charla.Respuesta
{
    public class CharlaDigosRespuesta
    {

        public int CharlaId { get; set; }
        public int CharlaPersonaId { get; set; }
        public int? CharlaDigoDeDigoId { get; set; }
        public string Digo { get; set; }
        public DateTime FechaDigo { get; set; }
    }
}
