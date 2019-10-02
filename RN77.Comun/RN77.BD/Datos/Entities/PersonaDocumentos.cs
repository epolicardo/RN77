namespace RN77.BD.Datos.Entities
{
    public partial class PersonaDocumentos : EntityBase
    {

        public int PersonaId { get; set; }
        public int DocumentoId { get; set; }

        public virtual Documentos Documento { get; set; }
        public virtual Personas Persona { get; set; }
    }
}
