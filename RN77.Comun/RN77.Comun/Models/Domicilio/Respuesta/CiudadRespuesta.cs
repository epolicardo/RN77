using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.Comun.Models.Domicilio.Respuesta
{
    public class CiudadRespuesta
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
        public int ProvinciaId { get; set; }
        public int PaisId { get; set; }
        public string NombrePais { get; set; }
        public string NombreProvincia { get; set; }
    }
}
