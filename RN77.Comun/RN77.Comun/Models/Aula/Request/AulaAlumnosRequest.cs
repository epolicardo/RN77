using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Aula.Request
{
   public class AulaAlumnosRequest
    {
        public int AulaId { get; set; }
        public int PersonaId { get; set; }
       
    }
}
