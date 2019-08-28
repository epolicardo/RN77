namespace RN77.BD.Datos.Entities
{
    public partial class CharlaDigoArchivos : EntityBase
    {

        public int? CharlaDigoId { get; set; }
        public string Path { get; set; }
        public string Comentario { get; set; }

        public virtual CharlaDigos CharlaDigo { get; set; }
    }
}
