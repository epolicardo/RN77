namespace RN77.BD.Datos.Entities
{
    public partial class InstitucionTels : EntityBase
    {

        public int InstitucionId { get; set; }
        public int TelId { get; set; }

        public virtual Instituciones Institucion { get; set; }
        public virtual Tels Tel { get; set; }
    }
}
