using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RN77.BD.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Password Actual")]
        public string oldPassword { get; set; }

        [Required]
        [Display(Name = "Password Nueva")]
        public string newPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }

}
