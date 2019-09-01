namespace RN77.BD.Datos
{
    using RN77.BD.Datos.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }

        [Required]
        public DateTime FechaCreaReg { get; set; }
        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaCreaLocal
        {
            get
            {
                if (this.FechaCreaReg == null)
                {
                    return null;
                }

                return this.FechaCreaReg.ToLocalTime();
            }
        }

        [Required]
        public DateTime FechaModifReg { get; set; }
        [Display(Name = "Fecha Modificación Local")]
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

        public DateTime? FechaBajaReg { get; set; }
        [Display(Name = "Fecha Baja Local")]
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

        [Required]
        public string ObservReg { get; set; }

        [Required]
        public Usuarios Usuario { get; set; }

        [Required]
        public byte EstadoReg { get; set; }
    }
}
