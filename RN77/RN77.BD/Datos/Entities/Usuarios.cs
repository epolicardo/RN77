namespace RN77.BD.Datos.Entities

{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Usuarios : IdentityUser
    {
        [Required]
        [Display(Name = "Alta")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaCreaReg { get; set; }

        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaCreaLocal
        {
            get
            {
                if (this.FechaBajaReg == null)
                {
                    return null;
                }
                return this.FechaCreaReg.ToLocalTime();
            }
        }

        [Required]
        [Display(Name = "Modificación")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaModifReg { get; set; }

        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaModifLocal
        {
            get
            {
                if (this.FechaModifReg == null)
                {
                    return null;
                }

                return this.FechaModifReg.ToLocalTime();
            }
        }

        [Display(Name = "Baja")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaBajaReg { get; set; }

        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaBajaLocal
        {
            get
            {
                if (this.FechaBajaReg == null)
                {
                    return null;
                }

                return this.FechaBajaReg.GetValueOrDefault();
            }
        }

        public int? PersonaId { get; set; }
        [Display(Name = "Persona")]
        public Personas Persona
        {
            get
            {
                if (this.PersonaId == null)
                {
                    return null;
                }
                var persona = new Personas();
                return persona;
            }
        }
    }
}
