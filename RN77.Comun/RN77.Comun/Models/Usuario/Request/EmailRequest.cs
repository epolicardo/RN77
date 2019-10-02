using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Usuario.Request
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
