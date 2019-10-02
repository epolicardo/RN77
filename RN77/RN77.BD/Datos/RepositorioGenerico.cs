namespace RN77.BD.Datos
{
    using Microsoft.EntityFrameworkCore;
    using RN77.BD.Helpers;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class, IEntityBase
    {
        private readonly RN77Context context;
        private readonly IUsuarioHelper usuarioHelper;

        //ToDo: actualizar usuario helper con usuario conectado
        public RepositorioGenerico(RN77Context context, IUsuarioHelper usuarioHelper)
        {
            this.context = context;
            this.usuarioHelper = usuarioHelper;
        }

        public IQueryable<T> GetAll()
        {
            return this.context.Set<T>().AsNoTracking();
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.Set<T>().Include(p => p.Usuario);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            entity.Usuario = await this.usuarioHelper.GetUserByEmailAsync("sergioalgorry@hotmail.com");
            entity.EstadoReg = 1;
            entity.FechaCreaReg = DateTime.Now;
            entity.FechaModifReg = DateTime.Now;
            if (entity.ObservReg == null)
            {
                entity.ObservReg = "";
            }

            await this.context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            entity.FechaModifReg = DateTime.Now;

            this.context.Set<T>().Update(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            entity.EstadoReg = 0;
            entity.FechaModifReg = DateTime.Now;

            this.context.Set<T>().Update(entity);
            //this.context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await this.context.Set<T>().AnyAsync(e => e.Id == id);

        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}