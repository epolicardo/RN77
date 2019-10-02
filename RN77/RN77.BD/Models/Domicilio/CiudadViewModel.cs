using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RN77.BD.Models.Domicilio
{
    public class CiudadViewModel
    {
        [Required]
        public int ProvinciaId { get; set; }

        [Required]
        public string NombreCiudad { get; set; }
    }
}
