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
        public DateTime FechaCrea { get; set; }

        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaCreaLocal
        {
            get
            {
                if (this.FechaCrea == null)
                {
                    return null;
                }
                return this.FechaCrea.ToLocalTime();
            }
        }

        [Required]
        [Display(Name = "Modificación")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaModif { get; set; }

        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaModifLocal
        {
            get
            {
                if (this.FechaModif == null)
                {
                    return null;
                }

                return this.FechaModif.ToLocalTime();
            }
        }

        [Display(Name = "Baja")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime FechaBaja { get; set; }

        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaBajaLocal
        {
            get
            {
                if (this.FechaBaja == null)
                {
                    return null;
                }

                return this.FechaBaja.ToLocalTime();
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
