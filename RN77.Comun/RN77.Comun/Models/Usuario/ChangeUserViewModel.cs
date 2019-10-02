using System.ComponentModel.DataAnnotations;


namespace RN77.Comun.Models.Usuario
{
    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
    }

}
