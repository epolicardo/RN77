namespace RN77.BD.Datos.Entities
{
    public partial class PersonaTels : EntityBase
    {

        public int PersonaId { get; set; }
        public int TelId { get; set; }

        public virtual Personas Persona { get; set; }
        public virtual Tels Tel { get; set; }
    }
}
