using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Domicilio.Respuesta
{
    public partial class ProvinciaRespuesta 
    {
        public int ProvinciaId { get; set; }
        public int PaisId { get; set; }
        public string NombrePais { get; set; }
        public string NombreProvincia { get; set; }
    }
}
