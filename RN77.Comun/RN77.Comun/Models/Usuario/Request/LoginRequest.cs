using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Usuario.Request
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Usuario { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public bool RecordarMe { get; set; }
    }
}
