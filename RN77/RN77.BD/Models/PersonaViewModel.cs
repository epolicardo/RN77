using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RN77.BD.Models.Persona
{
	public class PersonaViewModel
	{
		[Required]
		public string Nombre { get; set; }
		[Required]
		public string Apellido { get; set; }
	}
}
