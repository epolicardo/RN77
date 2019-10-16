using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Usuario.Request
{
    public class UsuarioRequest
    {
        [Required]
        //[Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        //[Display(Name = "Apellido")]
        public string Apellido { get; set; }

        //[Display(Name = "Nº Documento")]
        public string Documento { get; set; }

        //[Display(Name = "Tipo Doc.")]
        public int? TdocumentoCod { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        //[Display(Name = "Usuario(email)")]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        //[Display(Name = "Clave")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirmar { get; set; }
    }
}
