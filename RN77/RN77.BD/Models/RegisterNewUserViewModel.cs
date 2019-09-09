using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Apellido { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }

}
