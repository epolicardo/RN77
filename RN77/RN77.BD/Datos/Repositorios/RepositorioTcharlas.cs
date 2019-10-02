namespace RN77.BD.Datos.Repositorios
{
    using RN77.BD.Datos.Entities;
    using RN77.BD.Helpers;

    public class RepositorioTcharlas : RepositorioGenerico<Tcharlas>, IRepositorioTcharlas
    {
        private readonly RN77Context context;
        private readonly IUsuarioHelper usuarioHelper;

        public RepositorioTcharlas(RN77Context context, IUsuarioHelper usuarioHelper) : base(context, usuarioHelper)
        {
            this.context = context;
            this.usuarioHelper = usuarioHelper;
        }
    }
}
