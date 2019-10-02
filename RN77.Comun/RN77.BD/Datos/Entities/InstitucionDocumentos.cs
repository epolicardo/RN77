namespace RN77.BD.Datos.Entities
{
    public partial class InstitucionDocumentos : EntityBase
    {

        public int InstitucionId { get; set; }
        public int DocumentoId { get; set; }

        public virtual Documentos Documento { get; set; }
        public virtual Instituciones Institucion { get; set; }
    }
}
