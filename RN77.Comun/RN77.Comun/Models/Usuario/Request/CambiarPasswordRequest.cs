using System.ComponentModel.DataAnnotations;

namespace RN77.Comun.Models.Usuario
{
    public class CambiarPasswordRequest
    {
        [Required]
        [Display(Name = "eMail")]
        public string eMail { get; set; }

        [Required]
        [Display(Name = "Password Actual")]
        public string oldPassword { get; set; }

        [Required]
        [Display(Name = "Password Nueva")]
        public string newPassword { get; set; }

        [Required]
        [Compare("newPassword")]
        public string Confirm { get; set; }
    }

}
